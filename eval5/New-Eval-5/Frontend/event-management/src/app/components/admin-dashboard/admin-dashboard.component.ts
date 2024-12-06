import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { LoginService } from '../../services/login.service'; // Adjust path as needed
import { AuthGuard } from '../../auth.guard';
import { HttpClientModule } from '@angular/common/http';
@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.css'],
  standalone: true,
  imports: [CommonModule,HttpClientModule],
  providers: [LoginService,AuthGuard]
})
export class AdminDashboardComponent {
navigateToDashboard() {
throw new Error('Method not implemented.');
}

  constructor(private router: Router) {}

  // Navigate to the Add Event page
  navigateToAddEvent(): void {
    this.router.navigate(['/add-event']);
  }

  // Navigate to the Events List page
  navigateToEventsList(): void {
    this.router.navigate(['/event-list']);
  }

  // Navigate to the Registered Users List page
  navigateToRegisteredUsersList(): void {
    this.router.navigate(['/registered-users-list']);
  }
}
