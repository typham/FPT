import { Component, OnInit } from '@angular/core';
import { ProductService } from '../services/product.service';
import { Response } from '@angular/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  state = 'normal';
  products;
  product = {};
  constructor(private productService:ProductService, private router:Router) { }

  ngOnInit() {
    this.productService.getAll().subscribe((res:Response)=> this.products = res);
  }

  save(){
    console.log(this.product);
    this.productService.add(this.product).subscribe((res:Response)=> {
      this.products.push(res);
      this.changeState('normal');
    });
  }

  detailProduct(item){
    this.router.navigate(['/products/',item.Id]);
  }

  delete(item){
    var idx = this.products.indexOf(item);
    this.productService.delete(item.Id).subscribe((res:Response)=>{
      this.products.splice(idx,1);
    });
  }

  changeState(state){
    this.state = state;
    if(state == 'normal'){
      this.product = {};
    }
  }

}
