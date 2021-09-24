import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Customer } from '../customer';
import { CustomerService } from '../customer.service';

@Component({
  selector: 'app-customerlist',
  templateUrl: './customerlist.component.html',
  styleUrls: ['./customerlist.component.css']
})
export class CustomerlistComponent implements OnInit {

  //injecting services in the constructor.
  //constructor creates the class.. then html is created 
  constructor(private customerService: CustomerService) { }
  selectedCustomer?: Customer;
  customerlist: Customer[] = [];
  observablelist = this.customerService.CustomerList();

  //then, after service are set up, etc..you use the service to initialize values 
  ngOnInit(): void {
    this.observablelist.subscribe(x => this.customerlist = x)
  }

  customerdetails(id: number): void {
    this.selectedCustomer = this.customerlist.find(x => x.customerId === id);
  }
  //create functions to interact with th eapi thru the services (CustomerService)
  registernewcustomer(c: Customer): void {
    this.customerService.NewCustomer(c).subscribe(x => this.customerlist.push(x));
  }
}
