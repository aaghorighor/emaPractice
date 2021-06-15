import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [    
    {
        path: 'frontend',
        loadChildren: () => import('./frontend-theme/frontend-theme.module').then(m => m.FrontendThemeModule)
    },
    {
        path: 'contact',
        loadChildren: () => import('./contact/contact.module').then(m => m.ContactModule)
    },
    {
        path: 'features',
        loadChildren: () => import('./features/features.module').then(m => m.FeaturesModule)
    },    
    {
        path: 'screenshots',
        loadChildren: () => import('./screenshots/screenshots.module').then(m => m.ScreenShotsModule)
    },            
    {
        path: 'account',
        loadChildren: () => import('./accounts/accounts.module').then(m => m.AccountModule)
    }    
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class FrontendRoutingModule { }