import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FaqTwoComponent } from './faq-two.component';

@NgModule({
    declarations: [
        FaqTwoComponent
    ],
    imports: [ CommonModule ],
    exports: [
        FaqTwoComponent
    ],
    schemas : [CUSTOM_ELEMENTS_SCHEMA]
})
export class FaqModule {}