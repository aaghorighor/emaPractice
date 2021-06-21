
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import{BehaviorSubject} from 'rxjs';
import {map}  from 'rxjs/operators';
import { Login, Register } from '../model/user';

@Injectable()
export class UserService {
 
    //registerUrl = 'http://localhost:62137/api/account/register';
    loginUrl = 'http://localhost:62137/api/account/login';
    registerUrl = 'http://kcmkcm-001-site10.btempurl.com/api/account/register';    
    constructor(private http :HttpClient){
    }

    login(login: Login){
        return this.http.post(this.loginUrl, login)
        .pipe(
          map((response:any) => {
            const user = response;
            if(user){
              //localStorage.setItem('token',user.token);
              //localStorage.setItem('user', JSON.stringify(user.user));              
            }
          })
        );
      }   

    register(user :Register){
        return this.http.post(this.registerUrl, user);
    }

};