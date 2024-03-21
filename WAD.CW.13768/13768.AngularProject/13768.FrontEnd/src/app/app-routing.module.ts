import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePageComponent } from './pages/home-page/home-page.component';
import { ContactFormComponent } from './components/contact.form/contact.form.component';
import { EditContactComponent } from './components/edit-contact/edit-contact.component';
import { CompanyFormComponent } from './components/company.form/company.form.component';
import { CompaniesComponent } from './pages/companies/companies.component';
import { EditCompanyComponent } from './pages/edit-company/edit-company.component';
import { TeamsComponent } from './pages/teams/teams.component';

const routes: Routes = [
  {
    path: "",
    component: HomePageComponent,
  },
  {
    path: "createContact",
    component: ContactFormComponent
  },
  {
    path: "editContact/:id",
    component: EditContactComponent
  },
  {
    path: "createCompany",
    component: CompanyFormComponent
  },
  {
    path: "companies",
    component: CompaniesComponent
  },
  {
    path: "editCompany/:id",
    component: EditCompanyComponent
  },
  {
    path: "teams",
    component: TeamsComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
