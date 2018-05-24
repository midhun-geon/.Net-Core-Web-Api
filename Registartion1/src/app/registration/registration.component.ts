import { Component, OnInit } from '@angular/core';
import {UserModel} from './registration.model'
import { NgForm } from '@angular/forms';
import {RegistrationService} from './registration.service'
@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css'],
  providers:[RegistrationService]
})
export class RegistrationComponent implements OnInit {
  model: UserModel = new UserModel()
  constructor(public regser:RegistrationService) { }

  ngOnInit() {
  }
  onSubmit(form: NgForm) {
    // console.log(this.model.FirstName)
    // console.log(this.model.LastName)
    // console.log(this.model.Address)
    // console.log(this.model.Gender)
    // console.log(this.model.DateOfBirth)
    // console.log(this.model.Language)
    // console.log(this.model.Email)
    this.regser.postUserData(this.model).subscribe()
  }
}
