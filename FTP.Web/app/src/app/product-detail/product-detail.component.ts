import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import {ProductService } from '../services/product.service';
import {Response} from '@angular/http';
import {Router} from '@angular/router';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {
  Id:number;
  product = {};
  constructor(private route: ActivatedRoute, private router:Router, private productService:ProductService) { }

  ngOnInit() {
    this.route.params.subscribe(params=>{
      this.Id = +params['id'];
      this.productService.getById(this.Id).subscribe((res:Response)=> this.product = res);
    });
  }
  
  save(){
    this.productService.update(this.product).subscribe((res:Response)=> {
      this.router.navigate(['/products']);
    });
  }

}
