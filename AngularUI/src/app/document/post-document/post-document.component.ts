import { Component, OnInit } from '@angular/core';
import { Input } from '@angular/core';
import { HttpService } from 'src/app/http.service';

@Component({
  selector: 'app-post-document',
  templateUrl: './post-document.component.html',
  styleUrls: ['./post-document.component.css']
})
export class PostDocumentComponent implements OnInit {

  constructor(private httpService: HttpService) { }
  @Input() newDocument:any;

  Clients?:string;
  TypeDoc?: string;
  DateOfAdded?:string;
  Employer?:string;

  ngOnInit(): void {
    this.Clients=this.newDocument.Clients;
    this.TypeDoc=this.newDocument.TypeDoc;
    this.DateOfAdded=this.newDocument.DateOfAdded;
    this.Employer=this.newDocument.Employer;
  }

  addDocument()
  {
    var document =
    {
      Clients:this.Clients,
      TypeDoc:this.TypeDoc,
      DateOfAdded:this.DateOfAdded,
      Employer:this.Employer
    }
    this.httpService.editDocument(document).subscribe(data=>{alert(data.toString());});
  }
  changeDocument()
  {
    var document =
    {
      Clients:this.Clients,
      TypeDoc:this.TypeDoc,
      DateOfAdded:this.DateOfAdded,
      Employer:this.Employer
    }
    this.httpService.changeDocument(document).subscribe(data=>{alert(data.toString());});

  }

}
