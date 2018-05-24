import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {UserModel} from './registration.model'
@Injectable()
export class RegistrationService {
  // private instance variable to hold base url
  private serviceUrl = 'http://localhost:49650/api/user';

  // Resolve HTTP using the constructor
  constructor(private http: HttpClient) { }

  postUserData(model: UserModel) {
    return this.http.post<any>(`${this.serviceUrl}`, model)
  }
  
}
