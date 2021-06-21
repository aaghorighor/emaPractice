import { Routes } from '@angular/router';

export const FRONTEND_LAYOUT_ROUTES: Routes = [
    {
        path: '',
        loadChildren: () => import('../views/frontends/frontend.module').then(m => m.FrontendModule),
    }
];