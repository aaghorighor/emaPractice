import { Component, OnInit,Input } from '@angular/core';

@Component({
  selector: 'app-patient',
  templateUrl: './patient.component.html',
  styleUrls: ['./patient.component.css']
})
export class PatientComponent implements OnInit {

  constructor() { }

  @Input() numberPatient:string
 
  ngOnInit(): void {
  }

}
