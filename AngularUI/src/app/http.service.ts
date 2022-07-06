import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

 readonly url = "http://localhost:61720/api";

 constructor( private http: HttpClient) { }

 getAllInvoicesDebt():Observable<any[]>
 {
   return this.http.get<any>(this.url+"/InvoicesDebt");
 }

 getOneInvoicesDebt(Id:number):Observable<any>
 {
   return this.http.get(this.url+"InvoicesDebt"+"/"+Id);
 }

 editInvoicesDebt(value:any)
 {
   return this.http.post(this.url+"InvoicesDebt", value);
 }

 changeInvoicesDebt(value:any)
 {
   return this.http.put(this.url+"InvoicesDebt", value);
 }

 deleteInvoicesDebt(value:any)
 {
   return this.http.delete(this.url+"InvoicesDebt", value);
 }

}
