import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CompanyModel } from '../models/company.display.model';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  constructor(private http: HttpClient) { }

  createUrl: string = "http://localhost:13768/api/Company/Create";
  getByIdUrl: string = "http://localhost:13768/api/Company/GetCompanyById";
  getAllUrl: string = "http://localhost:13768/api/Company/GetAll";
  updateUrl: string = "http://localhost:13768/api/Company/Update";
  deleteUrl: string = "http://localhost:13768/api/Company/Delete";
  
  public create(dto: CompanyModel) : Observable<any>
  {
    const formData = new FormData();
    formData.append("Website", dto.website);
    formData.append("Name", dto.name);
    
    return this.http.post<any>(this.createUrl, formData);
  }

  public read(id: string): Observable<any>
  {
    return this.http.get<any>(`${this.getByIdUrl}/${id}`);
  }

  public readAll(): Observable<any>
  {
    return this.http.get<any>(this.getAllUrl);
  }

  public update(id: string, dto: CompanyModel): Observable<any>
  {
    const formData = new FormData();
    formData.append("Website", dto.website);
    formData.append("Name", dto.name);
    
    return this.http.post<any>(`${this.updateUrl}/${id}`, formData);
  }

  public delete(id: string): Observable<any>
  {
    return this.http.delete<any>(`${this.deleteUrl}/${id}`);
  }
}
