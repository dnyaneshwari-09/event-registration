import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { TicketType } from '../models/ticket-type.model';
import { Registration } from '../models/registration.model';

@Injectable({
  providedIn: 'root'
})
export class RegistrationService {
  private apiUrl = `https://localhost:7104/api/Registrations`;
  private ticketTypesUrl = `https://localhost:7104/api/TicketTypes`;

  constructor(private http: HttpClient) { }

  getTicketTypes(): Observable<TicketType[]> {
    return this.http.get<TicketType[]>(this.ticketTypesUrl).pipe(
      catchError(error => {
        console.error('Error fetching ticket types', error);
        return of([]);
      })
    );
  }

  submitRegistration(registrationData: Registration): Observable<any> {
    return this.http.post(this.apiUrl, registrationData).pipe(
      catchError(error => {
        console.error('Error submitting registration', error);
        return of(null);
      })
    );
  }
}
