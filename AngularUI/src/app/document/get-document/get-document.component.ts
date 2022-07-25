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

updateDocumentArray()
{
  this.httpService.getAllDocuments().subscribe(data =>{this.documentArray=data});
}
changeClick(item:any)
{

}
deleteClick(item:any)
{

}
}
