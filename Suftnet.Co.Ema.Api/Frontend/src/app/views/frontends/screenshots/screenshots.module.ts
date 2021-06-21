import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { FrontendHeaderModule } from '../frontend-header/frontend-header.module';
import { ScreenshotsComponent } from './screenshots.component';

@NgModule({
    declarations: [
        ScreenshotsComponent
    ],
    imports: [ FrontendHeaderModule ],
    exports: [
        ScreenshotsComponent
    ],
    schemas : [CUSTOM_ELEMENTS_SCHEMA]
})
export class ScreenShotsModule {}