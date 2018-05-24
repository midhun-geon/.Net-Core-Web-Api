import { BrowserModule } from '@angular/platform-browser';      
import { NgModule } from '@angular/core';      
import { FormsModule,ReactiveFormsModule } from '@angular/forms';      
import {      
  MatButtonModule,      
  MatMenuModule,      
  MatToolbarModule,      
  MatIconModule,      
  MatCardModule,      
  MatFormFieldModule,      
  MatInputModule,      
  MatDatepickerModule,      
  MatDatepicker,      
  MatNativeDateModule,      
  MatRadioModule,      
  MatSelectModule,      
  MatOptionModule,      
  MatSlideToggleModule,ErrorStateMatcher,ShowOnDirtyErrorStateMatcher      
} from '@angular/material';      
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';      
import { AppComponent } from './app.component';
import { RegistrationComponent } from './registration/registration.component';      
import {RegistrationService} from './registration/registration.service' ;
import { HttpClientModule } from '@angular/common/http'; 
import { HttpModule } from '@angular/http';

@NgModule({      
  declarations: [      
    AppComponent, RegistrationComponent      
  ],      
  imports: [      
    BrowserModule,      
    FormsModule,      
    ReactiveFormsModule,      
    MatButtonModule,      
    MatMenuModule,      
    MatToolbarModule,      
    MatIconModule,      
    MatCardModule,      
    BrowserAnimationsModule,      
    MatFormFieldModule,      
    MatInputModule,      
    MatDatepickerModule,      
    MatNativeDateModule,      
    MatRadioModule,      
    MatSelectModule,      
    MatOptionModule,      
    MatSlideToggleModule,
    HttpClientModule      
  ],      
  exports: [      
    MatButtonModule,      
    MatMenuModule,      
    MatToolbarModule,      
    MatIconModule,      
    MatCardModule,      
    BrowserAnimationsModule,      
    MatFormFieldModule,      
    MatInputModule,      
    MatDatepickerModule,      
    MatNativeDateModule,      
    MatRadioModule,      
    MatSelectModule,      
    MatOptionModule,      
    MatSlideToggleModule      
  ],      
  providers: [      
    {provide: ErrorStateMatcher, useClass: ShowOnDirtyErrorStateMatcher} ,
    { provide: RegistrationService, useClass: RegistrationService }     
  ],      
  bootstrap: [AppComponent]      
})      
export class AppModule { }      