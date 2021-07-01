import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';

@Component({
    selector: 'nav-profile',
    templateUrl: './nav-profile.component.html',
    changeDetection: ChangeDetectionStrategy.OnPush,
    host: {
        '[class.header-nav-item]': 'true'
    }
})
export class NavProfileComponent implements OnInit {
    constructor() { }

    profileMenuList = [
        {
            path: '',
            icon: 'feather icon-user',
            item: 'Profile'
        },
        {
            path: '',
            icon: 'feather icon-power',
            item: 'Sign Out'
        }
    ]

    ngOnInit(): void { }
}
