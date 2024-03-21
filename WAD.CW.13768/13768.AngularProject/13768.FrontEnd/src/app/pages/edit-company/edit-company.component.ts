import { Component, OnInit } from '@angular/core';
import { CompanyService } from 'src/app/services/company.service';
import { ActivatedRoute, Router } from '@angular/router';
import { CompanyModel } from 'src/app/models/company.display.model';
@Component({
  selector: 'app-edit-company',
  templateUrl: './edit-company.component.html',
  styleUrls: ['./edit-company.component.scss']
})
export class EditCompanyComponent implements OnInit {
  company: CompanyModel = new CompanyModel();

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private service: CompanyService) {}

  ngOnInit(): void {
    this.company.id = this.route.snapshot.paramMap.get('id') ?? "";
    this.service.read(this.company.id)
    .subscribe({
      next: value => {
        this.company = value;
      }
    })
  }

  editCompany() {
    this.service.update(this.company.id, this.company)
    .subscribe(onSuccess => {
      this.router.navigateByUrl("companies");
    })
  }
}
