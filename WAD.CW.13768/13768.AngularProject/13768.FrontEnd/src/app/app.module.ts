import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { ContactComponent } from './components/contact/contact.component';
import { ContactFormComponent } from './components/contact.form/contact.form.component';
import { TeamFormComponent } from './components/team.form/team.form.component';
import { CompanyFormComponent } from './components/company.form/company.form.component';
import { HomePageComponent } from './pages/home-page/home-page.component';
import { HeaderComponent } from './components/header/header.component';
import {MatSelectModule} from '@angular/material/select';
import { EditContactComponent } from './components/edit-contact/edit-contact.component';
import { CompaniesComponent } from './pages/companies/companies.component';
import { EditCompanyComponent } from './pages/edit-company/edit-company.component';
import { TeamsComponent } from './pages/teams/teams.component';

@NgModule({
  declarations: [
    AppComponent,
    TeamFormComponent,
    ContactFormComponent,
    CompanyFormComponent,
    HeaderComponent,
    EditContactComponent,
    CompaniesComponent,
    EditCompanyComponent,
    TeamsComponent
    
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    FormsModule,
    HomePageComponent,
    ContactComponent,
    MatSelectModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
