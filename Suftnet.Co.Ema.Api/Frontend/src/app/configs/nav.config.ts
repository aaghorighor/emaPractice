import { NavMenu } from '@app/shared/types/nav-menu.interface';

const dashboard: NavMenu[] = [
    {
        path: '/dashboard',
        title: 'Dashboard',
        translateKey: 'NAV.DASHBOARD',
        type: 'item',
        iconType: 'feather',
        icon: 'icon-home',
        key: 'dashboard',
        submenu: []
    },
]

const adminNavMenu: NavMenu[] = [
    {
        path: '',
        title: '',
        translateKey: '',
        type: 'title',
        iconType: 'feather',
        icon: 'icon-file',
        key: 'menu-with-title',
        submenu: [
            {
                path: '/menu-1',
                title: 'Menu 1',
                translateKey: 'Users',
                type: 'item',
                iconType: 'feather', 
                icon: 'icon-users',
                key: '',
                submenu: []
            },
            {
                path: '/menu-2',
                title: 'Menu 2',
                translateKey: 'Reports',
                type: 'item',
                iconType: 'feather',
                icon: 'icon-book-open',
                key: 'menu-with-title.menu-with-title-item-2',
                submenu: []
            },
            {
                path: '/menu-2',
                title: 'Menu 2',
                translateKey: 'Settings',
                type: 'item',
                iconType: 'feather',
                icon: 'icon-settings',
                key: 'menu-with-title.menu-with-title-item-2', 
                submenu: []
            },
        ]
    }
]

export const navConfiguration: NavMenu[] = [
    ...dashboard,  
    ...adminNavMenu    
]