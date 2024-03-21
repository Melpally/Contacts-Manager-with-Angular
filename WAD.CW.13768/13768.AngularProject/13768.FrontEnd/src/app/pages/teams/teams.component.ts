import { Component, OnInit } from '@angular/core';
import { CompanyModel } from 'src/app/models/company.display.model';
import { TeamModel } from 'src/app/models/team.display.model';
import { CompanyService } from 'src/app/services/company.service';
import { TeamService } from 'src/app/services/team.service';

@Component({
  selector: 'app-teams',
  templateUrl: './teams.component.html',
  styleUrls: ['./teams.component.scss']
})
export class TeamsComponent implements OnInit{
  teams: TeamModel[] = [];
  companies: CompanyModel[] = [];
  constructor(
      private teamService: TeamService,
      private companyService: CompanyService) { }

  ngOnInit(): void {
    this.teamService.readAll()
    .subscribe({
      next: values => {
        this.teams = values;
        this.teams.forEach(element => {
          this.companyService.read(element.companyId)
          .subscribe({
            next: value => {
              this.companies.push(value);
            }
          })
        });
      }
    })
  }
}
