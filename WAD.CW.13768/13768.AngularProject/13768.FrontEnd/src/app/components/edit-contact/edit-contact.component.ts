import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ContactCreateModel } from 'src/app/models/contact.create.model';
import { ContactDisplayModel } from 'src/app/models/contact.display.model';
import { TeamModel } from 'src/app/models/team.display.model';
import { ContactService } from 'src/app/services/contact.service';
import { TeamService } from 'src/app/services/team.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-edit-contact',
  templateUrl: './edit-contact.component.html',
  styleUrls: ['./edit-contact.component.scss']
})
export class EditContactComponent implements OnInit {
  newContact: ContactDisplayModel = new ContactDisplayModel();
  teams: TeamModel[] = [];
  managers: ContactDisplayModel[] = [];

  constructor(
    private route: ActivatedRoute,  
    private router: Router,
      private teamService: TeamService,
      private contactService: ContactService) { }

  editContact()
  {
    this.contactService.updateContact(this.newContact.id, this.newContact)
  .subscribe({
    next: value => {
      this.router.navigateByUrl("");
    }
  })
  }

  getTheListOfAllManagers()
  {
    this.contactService.getAllManagers()
    .subscribe({
        next: values => {
          this.managers = values;
        }
      });
  }

  getTeams()
  {
    this.teamService.readAll()
    .subscribe({
      next: values => {
        this.teams = values;
      }
    })
  }

  ngOnInit(): void {
    this.getTeams();
    this.getTheListOfAllManagers();
    this.newContact.id = this.route.snapshot.paramMap.get('id') ?? "";
    this.contactService.readContact(Number(this.newContact.id))
    .subscribe({
      next: value => {
        this.newContact = value;
        console.log(this.newContact.reportsTo)
      }
    })
  }
}
