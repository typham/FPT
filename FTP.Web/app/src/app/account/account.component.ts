import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountService } from '../services/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
})
export class AccountComponent implements OnInit {
  public loginForm = this.fb.group({
    username: ["", Validators.required],
    password: ["", Validators.required],
    grant_type:'password'
  });

  constructor(public fb: FormBuilder, private accountService: AccountService, private router:Router) { }

  ngOnInit() {
  }

  doLogin(event) {
    this.accountService.login(this.loginForm.value).subscribe(res=>{
      if(res.access_token){
        localStorage.setItem('access_token',res.access_token);
        localStorage.setItem('expires_in',res.expires_in);
        this.router.navigate(['']);
      }
    }, (error)=>{
      console.log(error.status);
    });
  }

}
