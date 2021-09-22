import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-forms-examples',
  templateUrl: './forms-examples.component.html',
  styleUrls: ['./forms-examples.component.css']
})
export class FormsExamplesComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  //form will have first name and lname, phone number, username, password

  reactiveformexample = new FormGroup({
    fname: new FormControl('', [Validators.required, Validators.maxLength(20), Validators.minLength(3), Validators.pattern('[a-zA-Z ]*')]),
    lname: new FormControl('', [Validators.required, Validators.maxLength(20), Validators.minLength(3)]),
    email: new FormControl('', Validators.email),
    phonenumber: new FormControl('', [Validators.required]),
    username: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required)

  });

  fname2?: string;
  lname2?: string;
  email2?: string;
  phonenumber2?: string;
  username2?: string;
  password2?: string;





  submitReactiveForm() {
    console.log(`fname - ${this.reactiveformexample.get(`fname`)?.value}, lname - ${this.reactiveformexample.get(`lname`)?.value}, email - ${this.reactiveformexample.get(`email`)?.value}, -phonenumber - ${this.reactiveformexample.get(`phonenumber`)?.value}, username - ${this.reactiveformexample.get(`username`)?.value}  password - ${this.reactiveformexample.get(`password`)?.value}`)

  }
  //getter method used in the HTML file to get the fname properties and display the prestine, valid etc 
  get fname() { return this.reactiveformexample.get(`fname`) } //shorthand to get the value needed for the html




  submitTemplateForm() {
    console.log(`fname - ${this.fname2}, lname - ${this.lname2}, email - ${this.email2}, -phonenumber - ${this.phonenumber2}, username - ${this.username2}  password - ${this.password2}`)
  }
}