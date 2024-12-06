export interface EventModel {
  eventId: string;  // Unique ID for the event
  eventName: string;  // Event Name
  ageLimit: number;  // Age limit for the event
  eventDateTime: Date;  // Date and time of the event
  eventPrice: number;  // Price of the event
  eventDuration: number;  // Duration of the event in hours
  eventDetails: string;  // Additional details about the event
  capacityAvailable: number;  // Total capacity available for the event

  // Ticket information
  vipTicketCount: number;  // Number of VIP tickets available
  generalTicketCount: number;  // Number of General tickets available
  economyTicketCount: number;  // Number of Economy tickets available

  // Foreign key references
  categoryId: string;  // The category of the event
  venueId: string;  // The venue where the event is held
  
 
}
