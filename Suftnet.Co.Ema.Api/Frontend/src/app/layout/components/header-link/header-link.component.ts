import { Component, OnInit,ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'app-header-link',
  templateUrl: './header-link.component.html',
  styleUrls: ['./header-link.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
    host: {
        '[class.header-nav-item]': 'true'
    }
})
export class HeaderLinkComponent implements OnInit {

  constructor() { }

  headerLinkList = [
    {
        path: '',
        icon: 'feather icon-user',
        item: 'Secretary'
    },
    {
      path: '',
      icon: 'feather icon-folder-plus', 
      item: 'Providers'
    },
    {
      path: '',
      icon: 'feather icon-users',
      item: 'Patients'
    },
    {
      path: '',
      icon: 'feather icon-book', 
      item: 'Account'
    },
    {
      path: '',
      icon: 'feather icon-plus-square',
      item: 'Pharmacy'
    }
]

  ngOnInit(): void {
  }

}
