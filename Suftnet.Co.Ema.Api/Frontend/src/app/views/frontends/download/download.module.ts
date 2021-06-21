import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DownloadComponent } from './download.component';

@NgModule({
    declarations: [
        DownloadComponent
    ],
    imports: [ CommonModule ],
    exports: [
        DownloadComponent
    ],
    schemas : [CUSTOM_ELEMENTS_SCHEMA]
})
export class DownloadModule {}