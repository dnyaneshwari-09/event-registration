import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators, AbstractControl, ValidationErrors } from '@angular/forms';
import { Router } from '@angular/router';
import { EventService } from '../../services/event.service';
import { TicketTypeService } from '../../services/ticket-type.service';
import { VenueService } from '../../services/venue.service';
import { EventModel } from '../../models/event.model';
import { Category } from '../../models/category.model';
import { Venue } from '../../models/Venue.model';
import { TicketType } from '../../models/ticket-type.model';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-event-form',
  templateUrl: './add-event.component.html',
  styleUrls: ['./add-event.component.css'],
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  providers: [EventService, TicketTypeService, VenueService],
})
export class EventFormComponent implements OnInit {
  eventForm: FormGroup;
  categories: Category[] = [];
  venues: Venue[] = [];
  ticketTypes: TicketType[] = [];
  cities: string[] = ['Pune', 'Mumbai', 'Nagpur', 'Satara', 'Bangalore'];
  successMessage: string = '';
  minDateTime: string | undefined;

  constructor(
    private fb: FormBuilder,
    private eventService: EventService,
    private ticketTypeService: TicketTypeService,
    private venueService: VenueService,
    private router: Router
  ) {
    this.eventForm = this.fb.group({
      eventName: ['', [Validators.required, Validators.maxLength(100)]],
      eventDateTime: ['', [Validators.required, this.dateValidator]],
      eventPrice: ['', [Validators.required, Validators.min(1)]],
      eventDuration: ['', [Validators.required, Validators.min(1)]],
      eventDetails: ['', [Validators.maxLength(500)]],
      capacityAvailable: [0, [Validators.required, Validators.min(1)]],
      categoryId: ['', Validators.required],
      venueId: ['', Validators.required],
      ageLimit: ['', [Validators.required, Validators.min(5)]],
      ticketTypeId: ['', Validators.required],
      vipTicketCount: [0, [Validators.required, Validators.min(0)]],
      generalTicketCount: [0, [Validators.required, Validators.min(0)]],
      economyTicketCount: [0, [Validators.required, Validators.min(0)]],
      maxCapacity: [0, Validators.required]  
    });

    // Listen for changes in ticket counts to ensure they sum up to maxCapacity
    this.eventForm.get('vipTicketCount')?.valueChanges.subscribe(() => this.updateTotalCapacity());
    this.eventForm.get('generalTicketCount')?.valueChanges.subscribe(() => this.updateTotalCapacity());
    this.eventForm.get('economyTicketCount')?.valueChanges.subscribe(() => this.updateTotalCapacity());
  }

  ngOnInit(): void {
    this.fetchCategories();
    this.fetchVenues();
    this.fetchTicketTypes();
    this.minDateTime = this.getCurrentDateTime();
  }

  // Function to get the current date and time in the format yyyy-MM-ddTHH:mm for the min attribute
  getCurrentDateTime(): string {
    const currentDate = new Date();
    const year = currentDate.getFullYear();
    const month = (currentDate.getMonth() + 1).toString().padStart(2, '0');
    const day = currentDate.getDate().toString().padStart(2, '0');
    const hours = currentDate.getHours().toString().padStart(2, '0');
    const minutes = currentDate.getMinutes().toString().padStart(2, '0');

    // Format to yyyy-MM-ddTHH:mm (the format required for datetime-local)
    return `${year}-${month}-${day}T${hours}:${minutes}`;
  }

  fetchCategories(): void {
    this.eventService.getCategories().subscribe({
      next: (categories) => (this.categories = categories),
      error: (err) => console.error(err),
    });
  }

  fetchVenues(): void {
    this.venueService.getVenues().subscribe({
      next: (venues) => (this.venues = venues),
      error: (err) => console.error(err),
    });
  }

  fetchTicketTypes(): void {
    this.ticketTypeService.getTicketTypes().subscribe({
      next: (ticketTypes) => (this.ticketTypes = ticketTypes),
      error: (err) => console.error(err),
    });
  }

  onVenueChange(event: Event): void {
    const target = event.target as EventTarget;
    if (target && target instanceof HTMLSelectElement) {
      const venueId = target.value;
      const selectedVenue = this.venues.find(venue => venue.venueId === venueId);
      
      if (selectedVenue) {
        this.eventForm.patchValue({
          maxCapacity: selectedVenue.maxCapacity,
          capacityAvailable: selectedVenue.maxCapacity
        });
        this.updateTotalCapacity();
      }
    }
  }

  updateTotalCapacity(): void {
    const vip = this.eventForm.get('vipTicketCount')?.value || 0;
    const general = this.eventForm.get('generalTicketCount')?.value || 0;
    const economy = this.eventForm.get('economyTicketCount')?.value || 0;
    const maxCapacity = this.eventForm.get('maxCapacity')?.value || 0;

    const total = vip + general + economy;
    if (total > maxCapacity) {
      this.eventForm.get('vipTicketCount')?.setErrors({ exceededCapacity: true });
      this.eventForm.get('generalTicketCount')?.setErrors({ exceededCapacity: true });
      this.eventForm.get('economyTicketCount')?.setErrors({ exceededCapacity: true });
    } else {
      this.eventForm.get('vipTicketCount')?.setErrors(null);
      this.eventForm.get('generalTicketCount')?.setErrors(null);
      this.eventForm.get('economyTicketCount')?.setErrors(null);
    }
  }

  dateValidator(control: AbstractControl): ValidationErrors | null {
    const selectedDate = new Date(control.value);
    const currentDate = new Date();
  
    // Reset the time part of both dates to compare only the date part
    selectedDate.setHours(0, 0, 0, 0);
    currentDate.setHours(0, 0, 0, 0);
  
    return selectedDate >= currentDate ? null : { invalidDate: true };
  }

  onSubmit(): void {
    if (this.eventForm.valid) {
      const newEvent: Event = this.eventForm.value;
      this.eventService.createEvent(newEvent).subscribe({
        next: (event) => {
          this.successMessage = 'Event created successfully!';
          this.eventForm.reset();
          setTimeout(() => {
            this.successMessage = '';
            this.router.navigate(['/event-list']);
          }, 3000); // Redirect after 3 seconds
        },
        error: (err) => console.error(err),
      });
    }
  }
}
