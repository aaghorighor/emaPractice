import { Component, OnInit,Input } from '@angular/core';

@Component({
  selector: 'app-appointment',
  templateUrl: './appointment.component.html',
  styleUrls: ['./appointment.component.css']
})
export class AppointmentComponent implements OnInit {

  constructor() { }

  @Input() appointment:string
 
  ngOnInit(): void {
  }

}
