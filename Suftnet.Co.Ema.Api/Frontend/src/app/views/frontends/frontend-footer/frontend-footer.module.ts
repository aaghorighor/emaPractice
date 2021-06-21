import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FooterFrontendComponent } from './frontend-footer.component';

@NgModule({
    declarations: [
        FooterFrontendComponent
    ],
    imports: [ CommonModule ],
    exports: [
        FooterFrontendComponent
    ],
    schemas : [CUSTOM_ELEMENTS_SCHEMA]
})
export class FooterFrontendModule {}