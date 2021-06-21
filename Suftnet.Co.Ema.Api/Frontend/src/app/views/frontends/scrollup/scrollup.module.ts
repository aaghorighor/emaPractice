import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { ScrollupComponent } from './scrollup.component';

@NgModule({
    declarations: [
        ScrollupComponent
    ],
    imports: [  ],
    exports: [
        ScrollupComponent
    ],
    schemas : [CUSTOM_ELEMENTS_SCHEMA]
})
export class ScrollupModule {}