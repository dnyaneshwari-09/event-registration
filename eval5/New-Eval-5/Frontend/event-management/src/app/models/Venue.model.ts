export interface Venue {
    venueId: string;
    venueName: string;
    venueAddress1: string;
    venueAddress2?: string;  // Optional
    city: string;
    state: string;
    pincode: string;
    maxCapacity: number;
  }
  