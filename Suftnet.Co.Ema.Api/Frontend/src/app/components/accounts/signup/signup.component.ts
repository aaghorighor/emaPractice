import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/services/UserService';
import {Router} from '@angular/router';
import { User } from 'src/app/model/user';
import{FormGroup, Validators, FormBuilder} from '@angular/forms';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  user:User;
  registerForm: FormGroup;

  constructor(private userService : UserService, private router :Router,private formBuilder: FormBuilder  ) { }

  ngOnInit(): void {
    this.createRegisterForm();
  }

  register(){
    if(this.registerForm.valid){
      this.user = Object.assign({}, this.registerForm.value);          
      this.userService.register(this.user).subscribe((user)=> {
        console.log(user);
        this.router.navigate(['/thanks']);
      }, error => {
        console.log(error);      
      }) 
    }
  }

  createRegisterForm(){
    this.registerForm = this.formBuilder.group({     
      company: ['', Validators.required],
      email:['', Validators.required],     
      phoneNumber:['', Validators.required],    
    });
  }
}
