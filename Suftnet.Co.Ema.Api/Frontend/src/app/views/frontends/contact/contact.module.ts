import { NgModule } from '@angular/core';
import { ContactComponent } from './contact.component';
import { ContactRoutingModule } from './contact.routing.module';

@NgModule({
    declarations: [
        ContactComponent
    ],
    imports: [ ContactRoutingModule ],
    exports: [
        ContactComponent
    ]
})
export class ContactModule {}