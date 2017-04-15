import { Injectable, OnInit } from '@angular/core';
import { HttpClient } from '../common/HttpClient';
import { Response, Headers} from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class ProductService {
  private urlApi = 'http://localhost:57025/api';
  constructor(private http:HttpClient) { }

  private headers = new Headers({'Authorization':`Bearer ${localStorage.getItem('access_token')}` });

  getAll(){
    return this.http.get(`${this.urlApi}/product/getall`).map((res:Response)=> res.json());
  }

  getById(id){
    return this.http.get(`${this.urlApi}/product/getbyid/${id}`).map((res:Response)=> res.json());
  }

  add(item){
    return this.http.post(`${this.urlApi}/product/add`,item).map((res:Response)=> res.json());
  }

  update(item){
    return this.http.put(`${this.urlApi}/product/update`,item);
  }

  delete(id){
    return this.http.delete(`${this.urlApi}/product/delete/${id}`);
  }

}
