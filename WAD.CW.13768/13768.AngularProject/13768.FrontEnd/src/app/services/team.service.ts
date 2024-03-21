import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { TeamModel } from '../models/team.display.model';

@Injectable({
  providedIn: 'root'
})
export class TeamService {

  constructor(private http: HttpClient) { }

  createUrl: string = "http://localhost:13768/api/Team/Create";
  getByIdUrl: string = "http://localhost:13768/api/Team/GetTeamById";
  getAllUrl: string = "http://localhost:13768/api/Team/GetAll";
  updateUrl: string = "http://localhost:13768/api/Team/Update";
  deleteUrl: string = "http://localhost:13768/api/Team/Delete";
  
  public create(dto: TeamModel) : Observable<any>
  {
    const formData = new FormData();
    formData.append("CompanyId", dto.companyId);
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

  public update(id: number, dto: TeamModel): Observable<any>
  {
    const formData = new FormData();
    formData.append("CompanyId", dto.companyId);
    formData.append("Name", dto.name);
    
    return this.http.post<any>(`${this.updateUrl}/${id}`, formData);
  }

  public delete(id: number): Observable<any>
  {
    return this.http.delete<any>(`${this.deleteUrl}/${id}`);
  }

}
