import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { CompanyModel } from 'src/app/models/company.display.model';
import { CompanyService } from 'src/app/services/company.service';

@Component({
  selector: 'app-company.form',
  templateUrl: './company.form.component.html',
  styleUrls: ['./company.form.component.scss']
})
export class CompanyFormComponent {

  newCompany: CompanyModel = new CompanyModel();

  constructor(
      private router: Router,
      private companyService: CompanyService) {  }

  createCompany() {
    this.companyService.create(this.newCompany)
    .subscribe(onSuccess=> {
      this.router.navigateByUrl("companies");
    });
  }
}
