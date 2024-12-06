import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { RegistrationService } from '../../services/registration.service';
import { TicketTypeService } from '../../services/ticket-type.service';
import { TicketType } from '../../models/ticket-type.model';
import { Registration } from '../../models/registration.model';
import jwt_decode from 'jwt-decode'; // Ensure jwt-decode is imported correctly
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css'],
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule,HttpClientModule],
  providers:[RegistrationService,TicketTypeService]
})
export class RegistrationComponent implements OnInit {
  registrationForm!: FormGroup;
  ticketTypes: TicketType[] = [];
  private eventId!: string;
  private userId!: string |null;
  

  constructor(
    private fb: FormBuilder,
    private registrationService: RegistrationService,
    private ticketTypeService: TicketTypeService,
    private route: ActivatedRoute,
    private router:Router
  ) { }

  ngOnInit(): void {
    this.registrationForm = this.fb.group({
      name: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      mobileNo: ['', [Validators.required, Validators.pattern('^[0-9]{10,15}$')]],
      age: ['', [Validators.required, Validators.min(1), Validators.max(120)]],
      gender: ['', Validators.required],
      ticketType: ['', Validators.required]
    });

    this.loadTicketTypes();

    this.route.paramMap.subscribe(params => {
      this.eventId = params.get('eventId') || '';
    });

   this.userId = this.getUserIdFromToken();
  }

  loadTicketTypes(): void {
    this.ticketTypeService.getTicketTypes().subscribe(data => {
      this.ticketTypes = data;
    });
  }

  private decodeToken(token: string): any {
    try {
      const parts = token.split('.');
      if (parts.length !== 3) {
        throw new Error('JWT does not have 3 parts');
      }
      const decoded = atob(parts[1]);
      return JSON.parse(decoded);
    } catch (error) {
      console.error('Error decoding token:', error);
      return null;
    }
  }

  private getUserIdFromToken(): string | null {
    const token = localStorage.getItem('token'); // Replace with your actual token retrieval logic
    if (token) {
      try {
        const decoded: any = this.decodeToken(token);
        console.log("id",decoded.sub)
        return decoded.sub|| null; // Adjust based on your token structure
      } catch (error) {
        console.error('Error decoding token:', error);
        return null;
      }
    }
    return null;
  }

  onSubmit(): void {
    if (this.registrationForm.valid) {
      const formValue = this.registrationForm.value;
      const postData: Registration = {
        userId: this.getUserIdFromToken(),
        eventId: this.eventId,
        name: formValue.name,
        email: formValue.email,
        mobileNo: formValue.mobileNo,
        age: formValue.age,
        gender: formValue.gender,
        ticketTypeId: formValue.ticketType
      };

      this.registrationService.submitRegistration(postData).subscribe({
        next: (response) => {
          console.log(response)
          alert('Registration successful!');
          this.router.navigate(['/payment', response.registrationId]);
         // this.registrationForm.reset();
        },
        error: (err) => {
          alert('Registration failed. Please try again.');
          console.error('Error during registration:', err);
        }
      });
    }
  }
   // Helper methods for validation messages
   get name() { return this.registrationForm.get('name'); }
   get email() { return this.registrationForm.get('email'); }
   get mobileNo() { return this.registrationForm.get('mobileNo'); }
   get age() { return this.registrationForm.get('age'); }
   get gender() { return this.registrationForm.get('gender'); }
   get ticketType() { return this.registrationForm.get('ticketType'); }
}
