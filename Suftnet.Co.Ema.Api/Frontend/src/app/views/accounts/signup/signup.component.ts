import { Component, OnInit } from '@angular/core';
import { UserService } from '@app/services/UserService';
import {Router} from '@angular/router';
import { Register } from '@app/model/user';
import { FormBuilder, FormGroup, Validators, FormControl } from "@angular/forms";

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  user:Register;
  form: FormGroup;

  constructor(private router : Router, private userService :UserService, private formBuilder: FormBuilder) {}

  ngOnInit(): void {
    this.createRegisterForm();   
  }

  onSubmit(){
    
    if(this.form.valid){
      this.user = Object.assign({}, this.form.value);          
      this.userService.register(this.user).subscribe((user)=> {
        console.log(user);
        this.router.navigate(['/thanks']);
      }, error => {
        console.log(error);      
      }) 
    }else {
      return false;
    }

    return false;
  }

  createRegisterForm(){
    this.form = this.formBuilder.group({     
      company: ["", [Validators.required]],
      email: ["", [Validators.required, Validators.email]],
      phoneNumber:["", [Validators.required]],    
      terms:[false, [Validators.required]], 
    });
  }
}

