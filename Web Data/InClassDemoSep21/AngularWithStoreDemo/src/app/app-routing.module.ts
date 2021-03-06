import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { LoginCustomerComponent } from './login-customer/login-customer.component';
import { RegisterCustomerComponent } from './register-customer/register-customer.component';
import { FormsExamplesComponent } from './forms-examples/forms-examples.component';
import { CustomerlistComponent } from './customerlist/customerlist.component';

const routes: Routes = [
  { path: '', redirectTo: `/`, pathMatch: 'full' },
  { path: `register`, component: RegisterCustomerComponent },
  { path: `login`, component: LoginCustomerComponent },
  { path: `exampleforms`, component: FormsExamplesComponent },
  { path: ' customerlist', component: CustomerlistComponent }
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]

})
export class AppRoutingModule { }
