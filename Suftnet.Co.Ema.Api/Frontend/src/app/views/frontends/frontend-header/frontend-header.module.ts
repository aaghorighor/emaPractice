import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FrontendHeaderComponent } from './frontend-header.component';

@NgModule({
    declarations: [
        FrontendHeaderComponent
    ],
    imports: [ CommonModule ],
    exports: [
        FrontendHeaderComponent
    ],
    schemas : [CUSTOM_ELEMENTS_SCHEMA]
})
export class FrontendHeaderModule {}