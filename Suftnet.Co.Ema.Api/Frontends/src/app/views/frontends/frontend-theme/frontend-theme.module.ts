import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { FrontendHeaderModule } from '../frontend-header/frontend-header.module';
import { ContactModule } from '../contact/contact.module';
import { FrontendThemeComponent } from './frontend-theme.component';
import { ScrollupModule } from '../scrollup/scrollup.module';
import { ScreenShotsModule } from '../screenshots/screenshots.module';
import { FeaturesModule } from '../features/features.module';
import { HomeModule } from '../home/home.module';
import { FrontThemeRoutingModule } from './frontend-theme.routing.module';
import { FooterFrontendModule } from '../frontend-footer/frontend-footer.module';

@NgModule({
    declarations: [
        FrontendThemeComponent
    ],
    imports: [FrontThemeRoutingModule,FooterFrontendModule,HomeModule,FrontendHeaderModule,ContactModule,ScrollupModule,ScreenShotsModule,FeaturesModule ],
    exports: [
     
    ]   
})
export class FrontendThemeModule {}