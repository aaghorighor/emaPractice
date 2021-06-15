import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ThemeTwoComponent } from './themes/theme-two/theme-two.component';
import { LoginComponent } from './components/accounts/login/login.component';
import { SignupComponent } from './components/accounts/signup/signup.component';
import { ResetComponent } from './components/accounts/reset/reset.component';
import { ThankYouComponent } from './components/thank-you/thank-you.component';

const routes: Routes = [
  {path: '', component: ThemeTwoComponent}, 
  {path: 'login', component: LoginComponent},
  {path: 'signup', component: SignupComponent},
  {path: 'reset', component: ResetComponent},  
  {path: 'thanks', component: ThankYouComponent}  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
