export interface Registration {
  registrationId?: string; // Optional since it's not required for submission
  userId: string |null;
  eventId: string;
  name: string;
  email: string;
  mobileNo: string;
  age: number;
  gender: string;
  ticketTypeId: string;
}
