export class ContactDisplayModel {
    id: string = "";
    name: string = "";
    avatar: string = "";
    email: string = "";
    phone: string = "";
    notes: string = "";
    address: string = "";
    jobTitle: string = "";
    isManager: boolean = false;
    dateOfBirth: Date = new Date();
    teamId: string = "";
    reportsTo: string | null = "";
  }