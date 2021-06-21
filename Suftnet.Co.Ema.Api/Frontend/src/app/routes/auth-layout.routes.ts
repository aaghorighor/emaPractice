import { Routes } from '@angular/router';

export const AUTH_LAYOUT_ROUTES: Routes = [
    {
        path: '',
        loadChildren: () => import('../views/accounts/accounts.module').then(m => m.AccountModule),
    }
];   
