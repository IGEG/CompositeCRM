import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InvoicesDebtComponent } from './invoices-debt/invoices-debt.component';
import { GetInvoicesComponent } from './invoices-debt/get-invoices/get-invoices.component';
import { PostInvoicesComponent } from './invoices-debt/post-invoices/post-invoices.component';
import { HttpService } from './http.service';
import { HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    AppComponent,
    InvoicesDebtComponent,
    GetInvoicesComponent,
    PostInvoicesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NgbModule
  ],
  providers: [HttpService],
  bootstrap: [AppComponent]
})
export class AppModule { }
