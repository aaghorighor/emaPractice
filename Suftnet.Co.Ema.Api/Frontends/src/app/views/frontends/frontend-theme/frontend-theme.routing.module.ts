import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FrontendThemeComponent } from './frontend-theme.component';

const routes: Routes = [
    {
        path: '',
        component: FrontendThemeComponent,
        data: {
            title: 'Home',
            hidePageHeader: true
        }
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class FrontThemeRoutingModule { }