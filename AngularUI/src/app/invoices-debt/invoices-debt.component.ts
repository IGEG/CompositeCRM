import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-invoices-debt',
  templateUrl: './invoices-debt.component.html',
  styleUrls: ['./invoices-debt.component.css']
})
export class InvoicesDebtComponent implements OnInit {

  constructor(private httpService: HttpService) { }

  ngOnInit(): void {
    this.updateInvoicesDebtArray();
  
  }

  invoicesDebtArray: any= [];

  updateInvoicesDebtArray()
  {
    this.httpService.getAllInvoicesDebt().subscribe(data=>{this.invoicesDebtArray=data;});
  }

}
