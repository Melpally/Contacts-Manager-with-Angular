import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { TeamService } from 'src/app/services/team.service';
import { TeamModel } from 'src/app/models/team.display.model';
import { ContactService } from 'src/app/services/contact.service';
import { ContactCreateModel } from 'src/app/models/contact.create.model';
import { ContactDisplayModel } from 'src/app/models/contact.display.model';

@Component({
  selector: 'app-contact-form',
  templateUrl: './contact.form.component.html',
  styleUrls: ['./contact.form.component.scss']
})
export class ContactFormComponent implements OnInit {
  teams: TeamModel[] = [];
  managers: ContactDisplayModel[] = [];
  newContact: ContactCreateModel = new ContactCreateModel();
  
  images: string[] = [
    "assets/icons/1.png",
    "assets/icons/2.png",
    "assets/icons/3.png",
    "assets/icons/4.png",
    "assets/icons/5.png",
    "assets/icons/6.png",
    "assets/icons/7.png",
    "assets/icons/8.png",
    "assets/icons/9.png",
    "assets/icons/10.png",
    "assets/icons/11.png",
    "assets/icons/12.png"
  ];

  constructor(private router: Router,
              private teamService: TeamService,
              private contactService: ContactService) { }

  ngOnInit(): void {
    this.getTheListOfAllManagers();
    this.getTeams();
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

  getAvatar()
  {
    return Math.floor(Math.random() * (11));
  }
  createContact()
  {
    this.newContact.avatar = this.images[this.getAvatar()];
    this.contactService.createContact(this.newContact)
    .subscribe(onCreated => {
        this.router.navigateByUrl('');
      })
  }
}
