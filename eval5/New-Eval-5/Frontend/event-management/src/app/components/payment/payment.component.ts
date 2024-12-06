import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrls: ['./payment.component.css'],
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule]
})
export class PaymentComponent implements OnInit {
  paymentForm!: FormGroup;
  registrationId!: string;
  registrationDetails: any = {};
  eventPrice: number = 0;
  ticketTypePrice: number = 0;
  totalAmount: number = 0;
  paymentMethods: string[] = ['Credit Card', 'Debit Card', 'UPI'];

  constructor(
    private fb: FormBuilder,
    private http: HttpClient,
    private route: ActivatedRoute,
    private router: Router,
    
  ) {}

  ngOnInit(): void {
    // Initialize the payment form
    this.paymentForm = this.fb.group({
      noOfTickets: [1, [Validators.required, Validators.min(1)]],
      paymentMethod: ['', Validators.required],
      totalAmount: [{ value: 0, disabled: true }]
    });

    // Trigger total amount calculation when number of tickets changes
    this.paymentForm.get('noOfTickets')?.valueChanges.subscribe(() => {
      this.calculateTotalAmount();
    });

    // Get registrationId from route
    this.registrationId = this.route.snapshot.paramMap.get('registrationId') || '';

    if (this.registrationId) {
      this.getRegistrationDetails(this.registrationId);
    }
  }

  // Fetch registration details using the registration ID
  getRegistrationDetails(registrationId: string): void {
    this.http.get<any>(`https://localhost:7104/api/Registrations/${registrationId}`).subscribe({
      next: (registration) => {
        this.registrationDetails = registration;
        const { eventId, ticketTypeId } = registration;

        if (eventId) {
          this.getEventDetails(eventId);
        }

        if (ticketTypeId) {
          this.getTicketTypeDetails(ticketTypeId);
        }
      },
      error: (error) => {
        console.error('Error fetching registration details:', error);
      }
    });
  }

  // Fetch event details using the event ID
  getEventDetails(eventId: string): void {
    this.http.get<any>(`https://localhost:7104/api/Events/${eventId}`).subscribe({
      next: (event) => {
        console.log(event)
        this.eventPrice = event.eventPrice
        ;
        console.log("event price",this.eventPrice)
        this.calculateTotalAmount(); // Recalculate total after event price is loaded
      },
      error: (error) => {
        console.error('Error fetching event details:', error);
      }
    });
  }

  // Fetch ticket type details using the ticket type ID
  getTicketTypeDetails(ticketTypeId: string): void {
    this.http.get<any>(`https://localhost:7104/api/TicketTypes/${ticketTypeId}`).subscribe({
      next: (ticketType) => {
        this.ticketTypePrice = ticketType.price;
        console.log("ticket price",this.ticketTypePrice)
        this.calculateTotalAmount(); // Recalculate total after ticket type price is loaded
      },
      error: (error) => {
        console.error('Error fetching ticket type details:', error);
      }
    });
  }

  // Calculate total amount based on number of tickets, event price, and ticket type price
  calculateTotalAmount(): void {
    const noOfTickets = this.paymentForm.get('noOfTickets')?.value || 1;

    // Ensure both event price and ticket type price are valid numbers before calculating
    if (this.eventPrice >= 0 && this.ticketTypePrice >= 0 && noOfTickets > 0) {
      this.totalAmount = noOfTickets * (this.eventPrice + this.ticketTypePrice);
      this.paymentForm.patchValue({ totalAmount: this.totalAmount });
    }
  }

  // Submit the payment form
  onSubmit(): void {
    if (this.paymentForm.valid) {
      const paymentData = {
        registrationId: this.registrationId,
        noOfTickets: this.paymentForm.get('noOfTickets')?.value,
        totalAmount: (this.eventPrice*( this.paymentForm.get('noOfTickets')?.value) )+this.ticketTypePrice,
        status: 'Confirmed',
        paymentMethod: this.paymentForm.get('paymentMethod')?.value
      };
console.log(paymentData);
// Store the data in local storage
localStorage.setItem('paymentData', JSON.stringify(paymentData));
      // POST payment data to API
      this.http.post(`https://localhost:7104/api/Payments`, paymentData).subscribe({
        next: (response) => {
          alert('Payment Successful!');
          this.router.navigate(['/registration-success', this.registrationId]);
        },
        error: (error) => {
          console.error('Error during payment', error);
        }
      });
    }
  }
}
