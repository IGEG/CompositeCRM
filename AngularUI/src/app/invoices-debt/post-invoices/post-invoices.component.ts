import { Component, OnInit, Input } from '@angular/core';
import { HttpService } from 'src/app/http.service';

@Component({
  selector: 'app-post-invoices',
  templateUrl: './post-invoices.component.html',
  styleUrls: ['./post-invoices.component.css']
})
export class PostInvoicesComponent implements OnInit {

  constructor(private httpSevice: HttpService) { }

  @Input() invDept: any;

  DepartmentNameDebt?: string;
  DateInvoicesDebt?: string;
  InvoiceNumberDebt?: string;
  ClientNameDebt?: string;
  InvoiceAmountDebt?: string;
  EmployeeFullNameDebt?: string;
  INNClientDebt?: string;
  InvoiseStatusDebt?: string;

  ngOnInit(): void {
    this.DepartmentNameDebt = this.invDept.DepartmentNameDebt;
    this.DateInvoicesDebt = this.invDept.DateInvoicesDebt;
    this.InvoiceNumberDebt = this.invDept.InvoiceNumberDebt;
    this.ClientNameDebt = this.invDept.ClientNameDebt;
    this.InvoiceAmountDebt = this.invDept.InvoiceAmountDebt;
    this.EmployeeFullNameDebt = this.invDept.EmployeeFullNameDebt;
    this.INNClientDebt = this.invDept.INNClientDebt;
    this.InvoiseStatusDebt = this.invDept.InvoiseStatusDebt;

  }

  addInvoicesDebt() {
    var invoiceDebt =
    {
      DepartmentNameDebt: this.DepartmentNameDebt,
      DateInvoicesDebt: this.DateInvoicesDebt,
      InvoiceNumberDebt: this.InvoiceNumberDebt,
      ClientNameDebt: this.ClientNameDebt,
      InvoiceAmountDebt: this.InvoiceAmountDebt,
      EmployeeFullNameDebt: this.EmployeeFullNameDebt,
      INNClientDebt: this.INNClientDebt,
      InvoiseStatusDebt: this.InvoiseStatusDebt
    };
    this.httpSevice.editInvoicesDebt(invoiceDebt).subscribe(data => { alert(data.toString()); });
  }

  changeInvoicesDebt() {
    var invoiceDebt =
    {
      DepartmentNameDebt: this.DepartmentNameDebt,
      DateInvoicesDebt: this.DateInvoicesDebt,
      InvoiceNumberDebt: this.InvoiceNumberDebt,
      ClientNameDebt: this.ClientNameDebt,
      InvoiceAmountDebt: this.InvoiceAmountDebt,
      EmployeeFullNameDebt: this.EmployeeFullNameDebt,
      INNClientDebt: this.INNClientDebt,
      InvoiseStatusDebt: this.InvoiseStatusDebt
    };
    this.httpSevice.changeInvoicesDebt(invoiceDebt).subscribe(data => { alert(data.toString()); });
  }

}


