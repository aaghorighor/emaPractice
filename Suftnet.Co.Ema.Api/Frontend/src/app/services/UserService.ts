
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import{BehaviorSubject} from 'rxjs';
import { User } from '../model/user';

@Injectable()
export class UserService {
 
    //baseUrl = 'http://localhost:62137/api/account/register';
    baseUrl = 'http://kcmkcm-001-site10.btempurl.com/api/account/register';    
    constructor(private http :HttpClient){
    }

    register(user :User){
        return this.http.post(this.baseUrl, user);
    }

};