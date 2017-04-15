import {Injectable} from '@angular/core';
import {Http, Headers} from '@angular/http';

@Injectable()

export class HttpClient{
    constructor(private http: Http){

    }

    setAuthenticationHeaders(header:Headers){
        header.append('Authorization',`Bearer ${localStorage.getItem('access_token')}`);
    }

    get(url){
        let headers = new Headers();
        this.setAuthenticationHeaders(headers);
        return this.http.get(url, {headers:headers});
    }

    post(url,data){
        let headers = new Headers();
        this.setAuthenticationHeaders(headers);
        return this.http.post(url, data,{headers:headers});
    }

    put(url,data){
        let headers = new Headers();
        this.setAuthenticationHeaders(headers);
        return this.http.put(url, data, {headers:headers});
    }

    delete(url){
        let headers = new Headers();
        this.setAuthenticationHeaders(headers);
        return this.http.delete(url, {headers:headers});
    }
}