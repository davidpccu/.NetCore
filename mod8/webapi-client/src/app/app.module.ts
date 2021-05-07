import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { HttpClientModule } from "@angular/common/http";
import { FormsModule } from "@angular/forms";
import { OperasComponent } from './operas/operas.component';
import { OperacreatComponent } from './operacreat/operacreat.component';
import { OperaEditComponent } from './opera-edit/opera-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    OperasComponent,
    OperacreatComponent,
    OperaEditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
