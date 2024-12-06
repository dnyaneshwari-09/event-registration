import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { FormGroup, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { NgxPaginationModule } from 'ngx-pagination';
declare var bootstrap: any;

interface Event {
  eventId: string;
  eventName: string;
  ageLimit: number;
  eventDateTime: string;
  eventPrice: number;
  eventDuration: number;
  eventDetails: string;
  capacityAvailable: number;
  vipTicketCount: number;
  generalTicketCount: number;
  economyTicketCount: number;
  categoryId: string;
  venueId: string;  // Event venue ID
}

interface Venue {
  venueId: string;
  venueName: string;
  venueAddress1: string;
  venueAddress2: string;
  city: string;
  state: string;
  pincode: string;
  maxCapacity: number;
}

@Component({
  selector: 'app-event-list',
  templateUrl: './event-list.component.html',
  styleUrls: ['./event-list.component.css'],
  standalone: true,
  imports:[CommonModule, HttpClientModule, FormsModule, NgxPaginationModule]
})
export class EventListComponent implements OnInit {
  events: Event[] = [];
  venues: Venue[] = [];
  filteredEvents: Event[] = [];
  searchQuery: string = '';
  sortField: string = 'eventName';
  sortOrder: string = 'asc';
  page: number = 1;
  pageSize: number = 5;
  selectedEvent: Event | null = null;
  selectedVenue: Venue | null = null;
  minAgeLimit: number | null = null;
  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.fetchEvents();
  }

  fetchEvents(): void {
    this.http.get<Event[]>('https://localhost:7104/api/Events').subscribe({
      next: (data) => {
        this.events = data;
        this.filteredEvents = data;
        this.sortEvents();
      },
      error: (err) => console.error('Error fetching events:', err),
    });

    // Fetch all venues for CSV export later
    this.http.get<Venue[]>('https://localhost:7104/api/Venue').subscribe({
      next: (data) => {
        this.venues = data;
      },
      error: (err) => console.error('Error fetching venues:', err),
    });
  }

  // searchEvents(): void {
  //   this.filteredEvents = this.events.filter((event) =>
  //     event.eventName.toLowerCase().includes(this.searchQuery.toLowerCase())
  //   );
  //   this.sortEvents();
  // }
  searchEvents(): void {
    this.filteredEvents = this.events.filter((event) => {
      const matchesSearchQuery = event.eventName.toLowerCase().includes(this.searchQuery.toLowerCase());
      const matchesAgeLimit = this.minAgeLimit === null || event.ageLimit >= this.minAgeLimit;
      return matchesSearchQuery && matchesAgeLimit;
    });
    this.sortEvents();
  }

  sortEvents(): void {
    this.filteredEvents.sort((a, b) => {
      let fieldA = a[this.sortField as keyof Event];
      let fieldB = b[this.sortField as keyof Event];

      if (typeof fieldA === 'string') {
        fieldA = fieldA.toLowerCase();
        fieldB = (fieldB as string).toLowerCase();
      }

      if (this.sortOrder === 'asc') {
        return fieldA > fieldB ? 1 : -1;
      } else {
        return fieldA < fieldB ? 1 : -1;
      }
    });
  }

  toggleSort(field: string): void {
    if (this.sortField === field) {
      this.sortOrder = this.sortOrder === 'asc' ? 'desc' : 'asc';
    } else {
      this.sortField = field;
      this.sortOrder = 'asc';
    }
    this.sortEvents();
  }

  openModal(event: Event): void {
    this.selectedEvent = event;
    this.fetchVenueDetails(event.venueId);

    const modalElement = document.getElementById('eventDetailsModal');
    const modal = new bootstrap.Modal(modalElement);
    modal.show();
  }

  fetchVenueDetails(venueId: string): void {
    this.http.get<Venue>(`https://localhost:7104/api/Venue/${venueId}`).subscribe({
      next: (data) => {
        this.selectedVenue = data;
      },
      error: (err) => console.error('Error fetching venue details:', err),
    });
  }

  /**
   * Updated CSV download logic to include event and venue details.
   */
  downloadCSV(): void {
    // Join event and venue data based on venueId
    const eventDataWithVenue = this.filteredEvents.map(event => {
      const venue = this.venues.find(v => v.venueId === event.venueId);
      return {
        ...event,
        venueName: venue ? venue.venueName : '',
        venueAddress1: venue ? venue.venueAddress1 : '',
        venueAddress2: venue ? venue.venueAddress2 : '',
        city: venue ? venue.city : '',
        state: venue ? venue.state : '',
        pincode: venue ? venue.pincode : '',
        maxCapacity: venue ? venue.maxCapacity : '',
      };
    });

    // Convert data to CSV format
    const csvData = this.convertToCSV(eventDataWithVenue);
    const blob = new Blob([csvData], { type: 'text/csv' });
    const url = window.URL.createObjectURL(blob);
    const a = document.createElement('a');
    a.href = url;
    a.download = 'events_with_venues.csv';
    a.click();
  }

  /**
   * Convert event and venue data into CSV format.
   */
  convertToCSV(data: any[]): string {
    const headers = [
      'Event Name',
      'Age Limit',
      'Event Date',
      'Price',
      'Duration (hours)',
      'Event Details',
      'Available Capacity',
      'Venue Name',
      'Venue Address1',
      'Venue Address2',
      'City',
      'State',
      'Pincode',
      'Max Venue Capacity'
    ];
  
    // Join headers with commas to create the first row
    const csvRows = data.map((event) => [
      event.eventName,
      event.ageLimit,
      new Date(event.eventDateTime).toLocaleString(),
      event.eventPrice,
      event.eventDuration,
      event.eventDetails,
      event.capacityAvailable,
      event.venueName,
      event.venueAddress1,
      event.venueAddress2 || 'N/A', // Provide default value if Address2 is empty
      event.city,
      event.state,
      event.pincode,
      event.maxCapacity
    ]);
  
    // Create a CSV string with rows and columns properly formatted
    const csvContent = [headers.join(','), ...csvRows.map(row => row.join(','))].join('\n');
    return csvContent;
  }
  
}
