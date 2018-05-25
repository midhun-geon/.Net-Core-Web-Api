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
  constructor(public regser:RegistrationService) {
  }
  ngOnInit() {
  }
  onSubmit(form: NgForm) {
    this.regser.postUserData(this.model).subscribe()
    form.resetForm()
  }
  ClearForm(){
    //form.resetForm()
   this.regser.getUserData().subscribe(results => {
    var mod = results[0].id;
    console.log(mod)
  }
  )
    
  }
}
