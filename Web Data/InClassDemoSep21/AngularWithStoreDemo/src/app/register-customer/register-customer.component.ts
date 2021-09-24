import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Customer } from '../customer';

@Component({
  selector: 'app-register-customer',
  templateUrl: './register-customer.component.html',
  styleUrls: ['./register-customer.component.css']
})
export class RegisterCustomerComponent implements OnInit {
  @Input() registertrue: boolean = false;
  fname: string = "";
  lname: string = "";
  @Output() passNewCustomerToParent = new EventEmitter<Customer>(); // emit this event when there is a customer to register 


  constructor() { }

  ngOnInit(): void {
    //this.registertrue = true;
  }

  registercustomer(): void {
    //in order to pass data up the component chain
    //you must emit an event from the child 
    //that is caught by the parent and handled
    let c: Customer = { customerId: 0, fname: this.fname, lname: this.lname };
    this.passNewCustomerToParent.emit(c);

  }

}
