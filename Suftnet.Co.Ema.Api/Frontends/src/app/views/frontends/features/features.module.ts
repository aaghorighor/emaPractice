import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FeaturesComponent } from './features.component';

@NgModule({
    declarations: [
        FeaturesComponent
    ],
    imports: [ CommonModule ],
    exports: [
        FeaturesComponent
    ],
    schemas : [CUSTOM_ELEMENTS_SCHEMA]
})
export class FeaturesModule {}