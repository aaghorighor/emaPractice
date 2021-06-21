import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DiscoverTwoComponent } from './discover-two.component';

@NgModule({
    declarations: [
        DiscoverTwoComponent
    ],
    imports: [ CommonModule ],
    exports: [
        DiscoverTwoComponent
    ],
    schemas : [CUSTOM_ELEMENTS_SCHEMA]
})
export class DiscoverModule {}