import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InvoicesDebtComponent } from './invoices-debt/invoices-debt.component';

const routes: Routes = [
  {
    path:"InvoicesDebt",component:InvoicesDebtComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
