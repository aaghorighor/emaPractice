import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WorkComponent } from './work.component';

@NgModule({
    declarations: [
        WorkComponent
    ],
    imports: [ CommonModule ],
    exports: [
        WorkComponent
    ],
    schemas : [CUSTOM_ELEMENTS_SCHEMA]
})
export class WorkModule {}