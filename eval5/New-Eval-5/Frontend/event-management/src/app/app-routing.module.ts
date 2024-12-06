import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SignupComponent } from './components/signup/signup.component';// Adjust the path as needed
import { LoginComponent } from './components/login/login.component';
import { EventFormComponent } from './components/add-event/add-event.component';
import { EventSelectionComponent } from './components/selection-screen/selection-screen.component';
import { RegistrationComponent } from './components/registration/registration.component';
import { AdminDashboardComponent } from './components/admin-dashboard/admin-dashboard.component';
import { EventListComponent } from './components/event-list/event-list.component';
import { RegisteredUsersListComponent } from './components/registered-users-list/registered-users-list.component';
import { AuthGuard } from '../app/auth.guard';
import { PaymentComponent } from './components/payment/payment.component';
import { RegistrationSuccessComponent } from './components/registration-success/registration-success.component';
export const routes: Routes = [
  { path: 'signup', component: SignupComponent },
  { path: 'login', component: LoginComponent },
  { path: 'add-event', component: EventFormComponent ,},
  { path: 'event-selection', component: EventSelectionComponent },
  { path: 'registration/:eventId', component: RegistrationComponent },
  { path: 'admin', component: AdminDashboardComponent, },
  { path: 'event-list', component: EventListComponent ,},
  { path: 'registered-users-list', component: RegisteredUsersListComponent ,},

  { path: 'payment', component: PaymentComponent ,},
  { path: 'payment/:registrationId', component: PaymentComponent },
  {path: 'registration-success/:registrationId',
  component: RegistrationSuccessComponent},
  { path: 'registration-success', component: RegistrationSuccessComponent ,},

  // other routes can go here
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
