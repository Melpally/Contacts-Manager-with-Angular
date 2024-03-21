export class ContactCreateModel {
    name: string = "";
    avatar: string = "";
    email: string = "";
    phone: string = "";
    notes: string = "";
    address: string = "";
    isManager: boolean = false;
    jobTitle: string = "";
    dateOfBirth: Date = new Date();
    teamId: string = "";
    reportsTo: string | null = "";
  }