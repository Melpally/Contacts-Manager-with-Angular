import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CompanyModel } from 'src/app/models/company.display.model';
import { CompanyService } from 'src/app/services/company.service';

@Component({
  selector: 'app-companies',
  templateUrl: './companies.component.html',
  styleUrls: ['./companies.component.scss']
})
export class CompaniesComponent implements OnInit {
  companies: CompanyModel[] = [];
  constructor(
    private router: Router,  
    private companyService: CompanyService) {  }

  ngOnInit(): void {
    this.companyService.readAll()
    .subscribe({
      next: values => {
        this.companies = values;
      }
    })
  }

  edit(id: string) {
    this.router.navigateByUrl(`editCompany/${id}`);
  }

  delete(id: string) {
    this.companyService.delete(id)
    .subscribe(onSuccess => {
      this.router.navigateByUrl("companies");
    });
  }
}
