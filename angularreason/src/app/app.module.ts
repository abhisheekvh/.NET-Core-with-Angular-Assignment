import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { ReasonDetailComponent } from './reason-details/reason-detail/reason-detail.component';
import { ReasonDetailService } from './share/reason-detail.service';
import {HttpClientModule} from "@angular/common/http";
//import {PopupModule} from 'ng2-opd-popup';

@NgModule({
  declarations: [
    AppComponent,
    
    ReasonDetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
   

  ],
  providers: [ReasonDetailService],
  bootstrap: [AppComponent]
})
export class AppModule { }
