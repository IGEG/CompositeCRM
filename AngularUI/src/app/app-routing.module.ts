import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InvoicesDebtComponent } from './invoices-debt/invoices-debt.component';
import { DocumentComponent } from './document/document.component';

const routes: Routes = [
  {path:"InvoicesDebt",component:InvoicesDebtComponent},
  {path:"Document",component:DocumentComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
