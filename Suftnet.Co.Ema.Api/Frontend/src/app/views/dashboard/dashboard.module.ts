import { NgModule } from '@angular/core';
import { CommonModule } from "@angular/common";
import { DashboardRoutingModule } from './dashboard-routing.module'
import { ProgressbarModule } from 'ngx-bootstrap/progressbar';
import { NgApexchartsModule } from "ng-apexcharts";
import { AvatarModule } from '@app/shared/components/avatar/avatar.module';
import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { DashboardComponent } from './dashboard.component';
import { BedsComponent } from './components/beds/beds.component';
import { AppointmentComponent } from './components/appointment/appointment.component';
import { DoctorComponent } from './components/doctor/doctor.component';
import { PatientComponent } from './components/patient/patient.component';

@NgModule({  
    declarations: [
        DashboardComponent,
        BedsComponent,
        AppointmentComponent,
        DoctorComponent,
        PatientComponent,
    ],
    imports: [
        CommonModule,
        DashboardRoutingModule,     
        NgApexchartsModule,
        ProgressbarModule,
        AvatarModule,
        PerfectScrollbarModule
    ],
    exports: [],
})
export class DashboardModule { }
