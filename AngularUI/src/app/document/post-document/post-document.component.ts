import { Component, OnInit } from '@angular/core';
import { Input } from '@angular/core';
import { HttpService } from 'src/app/http.service';

@Component({
  selector: 'app-post-document',
  templateUrl: './post-document.component.html',
  styleUrls: ['./post-document.component.css']
})
export class PostDocumentComponent implements OnInit {

  constructor() { }
  @Input() newDocument:any;

  ngOnInit(): void {
  }

}
