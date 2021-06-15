import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { FrontendHeaderModule } from '../frontend-header/frontend-header.module';
import { HomeComponent } from './home.component';

@NgModule({
    declarations: [
        HomeComponent
    ],
    imports: [  ],
    exports: [
        HomeComponent
    ],
    schemas : [CUSTOM_ELEMENTS_SCHEMA]
})
export class HomeModule {}