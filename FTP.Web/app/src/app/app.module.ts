import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClient } from './common/HttpClient';

// Check auth
import { AuthGuard } from './guards/auth.guard';

import { AppComponent } from './app.component';
import { ProductComponent } from './product/product.component';
import { HomeComponent } from './home/home.component';

import {ProductService} from './services/product.service';
import { AccountService } from './services/account.service';

import { ProductDetailComponent } from './product-detail/product-detail.component';
import { AccountComponent } from './account/account.component';

const routing:Routes = [
  {path: '',component: HomeComponent, canActivate: [AuthGuard]},
  {path: 'products',component: ProductComponent, canActivate: [AuthGuard]},
  {path: 'products/:id',component: ProductDetailComponent, canActivate: [AuthGuard]},
  {path: 'login',component: AccountComponent},
]

@NgModule({
  declarations: [
    AppComponent,
    ProductComponent,
    HomeComponent,
    ProductDetailComponent,
    AccountComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    ReactiveFormsModule,
    RouterModule.forRoot(routing)
  ],
  providers: [AuthGuard, HttpClient, ProductService,AccountService],
  bootstrap: [AppComponent]
})
export class AppModule { }
