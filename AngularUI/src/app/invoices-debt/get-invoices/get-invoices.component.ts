import { Component, OnInit } from '@angular/core';
import { HttpService } from 'src/app/http.service';

@Component({
  selector: 'app-get-invoices',
  templateUrl: './get-invoices.component.html',
  styleUrls: ['./get-invoices.component.css']
})
export class GetInvoicesComponent implements OnInit {

  constructor(private httpSevice: HttpService) { }


  invoicesDebtArray: any = [];

  ModalTitle?: string;
  ActivateAddInvDept: boolean = false;
  invDept: any;

  ngOnInit(): void {
    this.updateInvoicesDebtArray();
  }


  addClick() {
    this.invDept =
    {
      id:0,
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

  deleteClick(item:any)
  {
this.httpSevice.deleteInvoicesDebt(item.Id).subscribe(data=>{alert(data.toString());});
this.updateInvoicesDebtArray();
  }

  closeClick() {
    this.ActivateAddInvDept = false;
    this.updateInvoicesDebtArray();
  };

  updateInvoicesDebtArray() {
    this.httpSevice.getAllInvoicesDebt().subscribe(data => { this.invoicesDebtArray = data; });
  }

}
