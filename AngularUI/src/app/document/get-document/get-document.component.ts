import { Component, OnInit } from '@angular/core';
import { HttpService } from 'src/app/http.service';

@Component({
  selector: 'app-get-document',
  templateUrl: './get-document.component.html',
  styleUrls: ['./get-document.component.css']
})
export class GetDocumentComponent implements OnInit {

  constructor(private httpService: HttpService) { }

  ngOnInit(): void {
    this.updateDocumentArray();
  }

  documentArray: any = [];

  ModalTitle?:string;

  newDocument: any;

  ActivatedDocument: boolean=false;

updateDocumentArray()
{
  this.httpService.getAllDocuments().subscribe(data =>{this.documentArray=data});
}

addClick()
{
  this.newDocument=
  {
    Id:"",
    Clients:"",
    TypeDoc:"",
    DateOfAdded:"",
    Employer:""
  };
this.ActivatedDocument=true;
this.ModalTitle="Добавлние документа";
}
changeClick(item:any)
{
this.newDocument=item;
this.ModalTitle="Изменение документа";
this.ActivatedDocument=true;

}
deleteClick(item:any)
{
this.httpService.deleteDocument(item.Id).subscribe(data=>{alert(data.toString());});
this.updateDocumentArray();
}

closeClick()
{
  this.ActivatedDocument=false;
  this.updateDocumentArray();
}

}
