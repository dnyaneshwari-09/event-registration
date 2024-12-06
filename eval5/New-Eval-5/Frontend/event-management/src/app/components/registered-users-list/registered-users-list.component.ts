import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { EventService } from '../../services/event.service';
import { TicketTypeService } from '../../services/ticket-type.service';

@Component({
  selector: 'app-registered-users-list',
  templateUrl: './registered-users-list.component.html',
  styleUrls: ['./registered-users-list.component.css'],
  standalone: true,
  imports: [CommonModule, FormsModule],
  providers: [EventService, TicketTypeService]
})
export class RegisteredUsersListComponent implements OnInit {
  registeredUsers: any[] = [];
  filteredUsers: any[] = [];
  ticketTypes: any[] = []; // List of ticket types
  searchQuery: string = '';
  selectedTicketType: string = ''; // Model for ticket type dropdown
  sortField: string = 'name';
  sortDirection: string = 'asc';
  currentPage: number = 1;
  pageSize: number = 5;
  totalPages: number = 1;

  constructor(private http: HttpClient, private eventService: EventService, private ticketTypeService: TicketTypeService) {}

  ngOnInit(): void {
    this.fetchRegisteredUsers();
    this.fetchTicketTypes(); // Fetch ticket types
  }

  // Fetch registered users, event details, and ticket types
  fetchRegisteredUsers(): void {
    this.http.get('https://localhost:7104/api/Registrations').subscribe((data: any) => {
      this.registeredUsers = data;
      this.filteredUsers = data;

      // For each user, fetch their event and ticket type details
      this.registeredUsers.forEach((user) => {
        if (user.eventId) {
          this.eventService.getEventById(user.eventId).subscribe((eventData) => {
            user.eventDetails = eventData;
          });
        }

        if (user.ticketTypeId) {
          this.ticketTypeService.getTicketTypes().subscribe((ticketTypes) => {
            const ticketType = ticketTypes.find(type => type.ticketTypeId === user.ticketTypeId);
            user.ticketTypeName = ticketType ? ticketType.tickettype : 'Unknown';
          });
        }
      });

      this.calculateTotalPages();
    });
  }

  // Fetch ticket types for the dropdown
  fetchTicketTypes(): void {
    this.ticketTypeService.getTicketTypes().subscribe((data) => {
      this.ticketTypes = data;
    });
  }

  // Filter by ticket type
  onFilterByTicketType(): void {
    this.filteredUsers = this.registeredUsers.filter(user => {
      return this.selectedTicketType ? user.ticketTypeId === this.selectedTicketType : true;
    });

    // Additionally filter by search query if needed
    this.onSearch();
  }

  // Search by multiple fields including ticket type
  onSearch(): void {
    this.filteredUsers = this.registeredUsers.filter(user =>
      (user.name.toLowerCase().includes(this.searchQuery.toLowerCase()) ||
      user.email.toLowerCase().includes(this.searchQuery.toLowerCase()) ||
      user.mobileNo.toString().includes(this.searchQuery) ||
      user.age.toString().includes(this.searchQuery) ||
      user.gender.toLowerCase().includes(this.searchQuery) ||
      user.eventDetails?.eventName.toLowerCase().includes(this.searchQuery.toLowerCase())) &&
      (this.selectedTicketType ? user.ticketTypeId === this.selectedTicketType : true)
    );
    this.calculateTotalPages();
  }

  // Sort by any field
  onSort(field: string): void {
    this.sortField = field;
    this.sortDirection = this.sortDirection === 'asc' ? 'desc' : 'asc';
    this.filteredUsers.sort((a, b) => {
      const comparison = a[field] > b[field] ? 1 : -1;
      return this.sortDirection === 'asc' ? comparison : -comparison;
    });
  }

  // Pagination
  onPageChange(page: number): void {
    this.currentPage = page;
  }

  calculateTotalPages(): void {
    this.totalPages = Math.ceil(this.filteredUsers.length / this.pageSize);
  }

  // Export to CSV
  downloadCSV(): void {
    const csvData = this.filteredUsers.map(user => ({
      Name: user.name,
      Email: user.email,
      Mobile: user.mobileNo,
      Age: user.age,
      Gender: user.gender,
      Event: user.eventDetails?.eventName,
      TicketType: user.ticketTypeName
    }));
  
    const csvString = this.convertToCSV(csvData);
    const encodedUri = encodeURI('data:text/csv;charset=utf-8,' + csvString);
  
    const link = document.createElement('a');
    link.setAttribute('href', encodedUri);
    link.setAttribute('download', 'registered-users.csv');
    document.body.appendChild(link); // Required for Firefox
  
    link.click();
    document.body.removeChild(link);
  }
  

  convertToCSV(objArray: any[]): string {
    const header = Object.keys(objArray[0]).join(',');
    const rows = objArray.map(row => Object.values(row).join(',')).join('\r\n');
    return header + '\r\n' + rows;
  }
  
}
