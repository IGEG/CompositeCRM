import { Component, OnInit } from '@angular/core';
import { HttpService } from 'src/app/http.service';

@Component({
  selector: 'app-get-invoices',
  templateUrl: './get-invoices.component.html',
  styleUrls: ['./get-invoices.component.css']
})
export class GetInvoicesComponent implements OnInit {

  constructor(private httpSevice: HttpService) { }

  ngOnInit(): void {
    this.updateInvoicesDebtArray();
  }

  invoicesDebtArray: any = [];

  ModalTitle?: string;
  ActivateAddInvDept: boolean = false;
  invDept: any;

  addClick() {
    this.invDept =
    {
      DepartmentNameDebt: "",
      DateInvoicesDebt: "",
      InvoiceNumberDebt: 0,
      ClientNameDebt: "",
      InvoiceAmountDebt: 0,
      EmployeeFullNameDebt: "",
      INNClientDebt: 0,
      InvoiseStatusDebt: ""

    }
    this.ModalTitle = "Добавить новый документ";
    this.ActivateAddInvDept = true;
  };
  changeClick(item:any) {
    this.invDept = item;
    this.ModalTitle = "Изменение документа";
    this.ActivateAddInvDept = true;
  };

  closeClick() {
    this.ActivateAddInvDept = false;
    this.updateInvoicesDebtArray();
  };

  updateInvoicesDebtArray() {
    this.httpSevice.getAllInvoicesDebt().subscribe(data => { this.invoicesDebtArray = data; });
  }

}
