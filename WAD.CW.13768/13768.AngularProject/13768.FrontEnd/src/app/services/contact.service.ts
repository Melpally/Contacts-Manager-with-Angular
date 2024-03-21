import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { ContactCreateModel } from '../models/contact.create.model';
@Injectable({
  providedIn: 'root'
})
export class ContactService {

  constructor(private http: HttpClient) { }
  createUrl: string = "http://localhost:13768/api/Contact/Create";
  getAllUrl: string = "http://localhost:13768/api/Contact/GetAll";
  updateUrl: string = "http://localhost:13768/api/Contact/Update";
  deleteUrl: string = "http://localhost:13768/api/Contact/Delete";
  getByIdUrl: string = "http://localhost:13768/api/Contact/GetContactById";
  getAllManagersUrl: string = "http://localhost:13768/api/Contact/GetAllManagers";
  
  public createContact(contactDto: ContactCreateModel) : Observable<any>
  {
    const formData = new FormData();
    formData.append("Name", contactDto.name);
    formData.append("Email", contactDto.email);
    formData.append("Phone", contactDto.phone);
    formData.append("Notes", contactDto.notes);
    formData.append("TeamId", contactDto.teamId);
    formData.append("Avatar", contactDto.avatar);
    formData.append("Address", contactDto.address);
    formData.append("JobTitle", contactDto.jobTitle);
    formData.append("ReportsTo", contactDto.reportsTo ?? "");
    formData.append("DateOfBirth", contactDto.dateOfBirth.toString());
    formData.append("IsManager", contactDto.isManager == true ? "true" : "false");

    return this.http.post<any>(this.createUrl, formData);
  }

  public readContact(id: number): Observable<any>
  {
    return this.http.get<any>(`${this.getByIdUrl}/${id}`);
  }

  public readContacts(): Observable<any>
  {
    return this.http.get<any>(this.getAllUrl);
  }

  public updateContact(id: string, contactDto: ContactCreateModel): Observable<any>
  {
    const formData = new FormData();
    formData.append("Avatar", contactDto.avatar);
    formData.append("Email", contactDto.email);
    formData.append("Phone", contactDto.phone);
    formData.append("Notes", contactDto.notes);
    formData.append("Address", contactDto.address);
    formData.append("JobTitle", contactDto.jobTitle);
    formData.append("Name", contactDto.name);
    formData.append("DateOfBirth", contactDto.dateOfBirth.toString());
    formData.append("TeamId", contactDto.teamId);
    formData.append("ReportsTo", contactDto.reportsTo ?? "");
    formData.append("IsManager", contactDto.isManager == true ? "true" : "false");

    return this.http.post<any>(`${this.updateUrl}/${id}`, formData);
  }

  public deleteContact(id: string): Observable<any>
  {
    return this.http.delete<any>(`${this.deleteUrl}/${id}`);
  }

  public getAll() : Observable<any>
  {
    return this.http.get<any>(this.getAllUrl);
  }

  public getAllManagers() : Observable<any>
  {
    return this.http.get<any>(this.getAllManagersUrl);
  }
}
