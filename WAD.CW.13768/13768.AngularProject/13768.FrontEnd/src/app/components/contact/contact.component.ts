import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CompanyModel } from 'src/app/models/company.display.model';
import { ContactDisplayModel } from 'src/app/models/contact.display.model';
import { TeamModel } from 'src/app/models/team.display.model';
import { CompanyService } from 'src/app/services/company.service';
import { ContactService } from 'src/app/services/contact.service';
import { TeamService } from 'src/app/services/team.service';

@Component({
  selector: 'app-contact',
  standalone: true,
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.scss']
})
export class ContactComponent implements OnInit {
  @Input() contact: ContactDisplayModel = new ContactDisplayModel();
  
  team: TeamModel = new TeamModel();
  company: CompanyModel = new CompanyModel();
  constructor(
      private router: Router,
      private teamService: TeamService,
      private contactService: ContactService,
      private companyService: CompanyService) { }

  ngOnInit(): void {
    this.teamService.read(this.contact.teamId)
    .subscribe({
      next: value => {
        this.team = value;
        this.companyService.read(this.team.companyId)
        .subscribe({
          next: value => {
            this.company = value;
            console.log(this.company.name);
          }
        })
      }
    });

  }
  edit() {
    this.router.navigateByUrl(`editContact/${this.contact.id}`);
  }

  delete() {
    this.contactService.deleteContact(this.contact.id)
    .subscribe(onSuccess => {
      this.router.navigateByUrl("");
    });
  }
}
