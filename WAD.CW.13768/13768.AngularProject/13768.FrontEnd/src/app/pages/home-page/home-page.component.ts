import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ContactService } from 'src/app/services/contact.service';
import { ContactComponent } from 'src/app/components/contact/contact.component';
import { ContactDisplayModel } from 'src/app/models/contact.display.model';

@Component({
  selector: 'app-home-page',
  standalone: true,
  imports: [ContactComponent, 
            CommonModule],
  
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent implements OnInit {
  contacts: ContactDisplayModel[] = [];

  constructor(private contactService: ContactService) { }

  ngOnInit(): void {
    this.contactService.getAll()
    .subscribe({
      next: values => {
        this.contacts = values;
      }
    })
  }
}
