import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Venue } from '../models/Venue.model';// Assuming the Venue model is defined in venue.model.ts

@Injectable({
  providedIn: 'root'
})
export class VenueService {
  private apiUrl = 'https://localhost:7104/api/Venue';  // Replace with the actual API URL

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private http: HttpClient) { }

  // Get all venues
  getVenues(): Observable<Venue[]> {
    return this.http.get<Venue[]>(this.apiUrl);
  }

  // Get venue by ID
  getVenueById(id: string): Observable<Venue> {
    const url = `${this.apiUrl}/${id}`;
    return this.http.get<Venue>(url);
  }

  // Add a new venue
  addVenue(venue: Venue): Observable<Venue> {
    return this.http.post<Venue>(this.apiUrl, venue, this.httpOptions);
  }

  // Update an existing venue
  updateVenue(id: string, venue: Venue): Observable<any> {
    const url = `${this.apiUrl}/${id}`;
    return this.http.put(url, venue, this.httpOptions);
  }

  // Delete a venue
  deleteVenue(id: string): Observable<any> {
    const url = `${this.apiUrl}/${id}`;
    return this.http.delete(url, this.httpOptions);
  }
}
