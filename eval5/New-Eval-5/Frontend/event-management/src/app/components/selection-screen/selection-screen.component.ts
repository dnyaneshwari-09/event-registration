import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EventService } from '../../services/event.service';
import { EventModel } from '../../models/event.model';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
declare var bootstrap: any;

@Component({
  selector: 'app-event-selection',
  templateUrl: './selection-screen.component.html',
  styleUrls: ['./selection-screen.component.css'],
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  providers: [EventService],
})
export class EventSelectionComponent implements OnInit {
  events: EventModel[] = [];
  futureEvents: EventModel[] = [];
  selectedEvent: EventModel | null = null;
  selectedEventId: string | null | undefined;

  constructor(
    private eventService: EventService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.fetchEvents();
  }

  fetchEvents(): void {
    this.eventService.getEvents().subscribe({
      next: (events: EventModel[]) => {
        this.events = events;
        this.filterFutureEvents();
      },
      error: (err) => console.error('Error fetching events:', err),
    });
  }

  filterFutureEvents(): void {
    const currentDate = new Date();
    this.futureEvents = this.events.filter(event => new Date(event.eventDateTime) > currentDate);
  }

  openDetailsModal(event: EventModel): void {
    this.selectedEvent = event;
    this.selectedEventId = event.eventId;
    const modalElement = document.getElementById('eventDetailsModal');
    if (modalElement) {
      const modal = new bootstrap.Modal(modalElement);
      modal.show();
    }
  }

  selectEvent(event: EventModel): void {
    // Route to registration page with event ID
    this.router.navigate(['/registration', event.eventId]);
  }

  closeModal(): void {
    this.selectedEvent = null;
    const modalElement = document.getElementById('eventDetailsModal');
    if (modalElement) {
      const modal = bootstrap.Modal.getInstance(modalElement);
      modal?.hide();
    }
  }

}
