import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';  
import { LoginComponent } from './login/login.component';
import { SignupComponent } from './signup/signup.component';
import { ResetComponent } from './reset/reset.component';
import { AccountRoutingModule } from './accounts.routing.module';
import { NgBootstrapFormValidationModule } from 'ng-bootstrap-form-validation';
import { SharedModule } from '@app/shared/shared.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import{HttpClientModule} from '@angular/common/http'

@NgModule({
    declarations: [ 
        LoginComponent,
        SignupComponent,
        ResetComponent         
    ],
    imports : [
        CommonModule,
        AccountRoutingModule,     
        SharedModule,    
        FormsModule,
        ReactiveFormsModule,
        HttpClientModule,
        NgBootstrapFormValidationModule.forRoot(),
    ]
})

export class AccountModule { }