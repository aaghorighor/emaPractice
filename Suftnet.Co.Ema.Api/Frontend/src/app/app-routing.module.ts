import { NgModule } from '@angular/core';
import { RouterModule, Routes, PreloadAllModules } from '@angular/router';

import { AuthLayoutComponent } from "./layout/auth-layout/auth-layout.component";
import { AppLayoutComponent } from "./layout/app-layout/app-layout-component";
import { FrontendLayoutComponent } from './layout/frontend-layout/frontend-layout.component';

import { AUTH_LAYOUT_ROUTES } from "./routes/auth-layout.routes";
import { APP_LAYOUT_ROUTES } from './routes/app-layout.routes';
import { FRONTEND_LAYOUT_ROUTES } from './routes/frontend-layout.routes';

const appRoutes: Routes = [
    {
        path: '',
        redirectTo: '/frontend',
        pathMatch: 'full',
    },
    { 
        path: '', 
        component: AppLayoutComponent,
        children: APP_LAYOUT_ROUTES 
    },
    { 
        path: '', 
        component: AuthLayoutComponent, 
        children: AUTH_LAYOUT_ROUTES
    },
    { 
        path: '', 
        component: FrontendLayoutComponent, 
        children: FRONTEND_LAYOUT_ROUTES
    }
];

@NgModule({
    imports: [
        RouterModule.forRoot(appRoutes, {
            preloadingStrategy: PreloadAllModules,
            anchorScrolling: 'enabled',
            scrollPositionRestoration: 'enabled',
            relativeLinkResolution: 'legacy'
        })
    ],
    exports: [
        RouterModule
    ]
})

export class AppRoutingModule {
}