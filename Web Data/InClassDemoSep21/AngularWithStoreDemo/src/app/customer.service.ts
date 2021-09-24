import { HttpClient, HttpHeaders, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Customer } from './customer';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private http: HttpClient) { }

  //not implemented by me get the customer listv form an Api that fetches customers(usage of swagger helps)
  private url = 'http://localhost:5000/Customer/'

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };


  //cerate functions to make http request and other various and sundry actions 
  CustomerList(): Observable<Customer[]> {
    return this.http.get<Customer[]>(`${this.url} Customerlist`);
    //return this.http.get<Customer[]>(`https://localhost:44330/Customer/CustomerList`);
  }

  NewCustomer(): Observable<Customer> {
    return this.http.post<Customer>(``);
  }
}
