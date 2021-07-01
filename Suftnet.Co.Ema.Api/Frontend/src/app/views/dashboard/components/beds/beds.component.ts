import { Component, OnInit,Input } from '@angular/core';

@Component({
  selector: 'app-beds',
  templateUrl: './beds.component.html',
  styleUrls: ['./beds.component.css']
})
export class BedsComponent implements OnInit {

  constructor() { }

  @Input() beds:string

  ngOnInit(): void {
  }

}
