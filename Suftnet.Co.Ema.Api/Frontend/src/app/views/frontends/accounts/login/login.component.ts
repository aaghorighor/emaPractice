import { Component, OnInit } from '@angular/core';

import {Router} from '@angular/router';

import { FormBuilder, FormGroup, Validators, FormControl } from "@angular/forms";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  //login:Login;
  form: FormGroup;

  constructor(private router : Router, private formBuilder: FormBuilder) {}

  ngOnInit(): void {
    this.createLoginForm(); 
  }

  onSubmit(){  

    this.router.navigate(['/dashboard']);

    // if(this.form.valid){
    //   this.login = Object.assign({}, this.form.value);          
    //   this.userService.login(this.login).subscribe((login)=> {
    //     console.log(login);
    //     this.router.navigate(['/dashboard']);
    //   }, error => {
    //     console.log(error);      
    //   }) 
    // }else {
    //   return false;
    // }

    return false;
  }

  createLoginForm(){
    this.form = this.formBuilder.group({       
      email: ["", [Validators.required, Validators.email]],
      password:["", [Validators.required]]
    });
  }

}
