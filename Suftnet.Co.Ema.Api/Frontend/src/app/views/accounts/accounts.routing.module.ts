import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { SignupComponent } from './signup/signup.component';
import { ResetComponent } from './reset/reset.component';
import { ThankYouComponent } from './thank-you/thank-you.component';

const routes: Routes = [
    {
        path: 'login',
        component: LoginComponent 
    },
    {
        path: 'signup',
        component: SignupComponent 
    },
    {
        path: 'reset',
        component: ResetComponent 
    },
    {
        path: 'thanks',
        component: ThankYouComponent 
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class AccountRoutingModule { }