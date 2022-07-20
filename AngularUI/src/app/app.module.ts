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
import { DocumentComponent } from './document/document.component';
import { GetDocumentComponent } from './document/get-document/get-document.component';
import { PostDocumentComponent } from './document/post-document/post-document.component';

@NgModule({
  declarations: [
    AppComponent,
    InvoicesDebtComponent,
    GetInvoicesComponent,
    PostInvoicesComponent,
    DocumentComponent,
    GetDocumentComponent,
    PostDocumentComponent
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
