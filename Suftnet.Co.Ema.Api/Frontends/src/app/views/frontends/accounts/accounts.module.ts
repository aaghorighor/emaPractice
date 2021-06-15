import { NgModule } from '@angular/core';
import { LoginComponent } from './login/login.component';
import { SignupComponent } from './signup/signup.component';
import { ResetComponent } from './reset/reset.component';
import { AccountRoutingModule } from './accounts.routing.module';
import { NgBootstrapFormValidationModule } from 'ng-bootstrap-form-validation';
import { FrontendHeaderModule } from '../frontend-header/frontend-header.module';

@NgModule({
    declarations: [ 
        LoginComponent,
        SignupComponent,
        ResetComponent         
    ],
    imports : [
        AccountRoutingModule, 
        FrontendHeaderModule,        
        NgBootstrapFormValidationModule.forRoot(),
    ]
})

export class AccountModule { }