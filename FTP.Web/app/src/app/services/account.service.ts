import { Injectable } from '@angular/core';
import { Http, Response, Headers} from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class AccountService {
  private urlApi = 'http://localhost:57025';

  constructor(private http:Http) { }
  login(item){
    let headers = new Headers();
    headers.append('Content-Type','x-www-form-urlencoded');

    var urlencoded = `username=${item.username}&password=${item.password}&grant_type=password`;
    return this.http.post(`${this.urlApi}/token`,urlencoded, {headers: headers}).map((res:Response)=> res.json());
  }

  isAuthenticated(){
    return localStorage.getItem('auth_token')==null?false:true;
  }
}
