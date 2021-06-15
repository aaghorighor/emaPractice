import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{HttpClientModule} from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { WorkComponent } from './components/work/work.component';
import { DownloadComponent } from './components/download/download.component';
import { ContactComponent } from './components/contact/contact.component';
import { FooterOneComponent } from './components/footer/footer-one/footer-one.component';
import { ScrollupComponent } from './components/scrollup/scrollup.component';
import { ThemeTwoComponent } from './themes/theme-two/theme-two.component';
import { WelcomeTwoComponent } from './components/welcome/welcome-two/welcome-two.component';
import { FeatureTwoComponent } from './components/features/feature-two/feature-two.component';
import { DiscoverTwoComponent } from './components/discover/discover-two/discover-two.component';
import { ServiceTwoComponent } from './components/services/service-two/service-two.component';
import { ScreenshotTwoComponent } from './components/screenshots/screenshot-two/screenshot-two.component';
import { FaqTwoComponent } from './components/faq/faq-two/faq-two.component';
import { LoginComponent } from './components/accounts/login/login.component';
import { SignupComponent } from './components/accounts/signup/signup.component';
import { ResetComponent } from './components/accounts/reset/reset.component';
import { HeaderTwoComponent } from './components/header/header-two/header-two.component';
import { ThankYouComponent } from './components/thank-you/thank-you.component';
import { UserService } from './services/UserService';
import { AlertifyService } from './services/AlertifyService';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,     
    WorkComponent,    
    DownloadComponent,   
    ContactComponent,
    FooterOneComponent,   
    ScrollupComponent,   
    ThemeTwoComponent,
    WelcomeTwoComponent,
    FeatureTwoComponent,
    DiscoverTwoComponent,
    ServiceTwoComponent,
    ScreenshotTwoComponent,   
    FaqTwoComponent,        
    LoginComponent,
    SignupComponent,
    ResetComponent,  
    HeaderTwoComponent,
    ThankYouComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [UserService,AlertifyService],
  bootstrap: [AppComponent]
})
export class AppModule { }
