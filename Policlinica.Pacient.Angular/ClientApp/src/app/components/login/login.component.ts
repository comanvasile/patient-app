import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { LoginService } from 'src/app/services/login.service';
import { HttpResponse } from '@angular/common/http';
import { Router } from '@angular/router';
import { LoginPacient } from 'src/app/models/login.pacient';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;
  hide=true;
  errorMessage='';
  constructor(private fb:FormBuilder,private loginService:LoginService,private router:Router) { }

  ngOnInit() {
    this.createForm();
  }
  createForm(){
    this.loginForm = this.fb.group({
      email: ['', Validators.required],
      password: ['', Validators.required]
    });
  }
  login(){
    const loginPacient = new LoginPacient(this.loginForm.value.email, this.loginForm.value.password);
    this.loginService.submitLogin(loginPacient).subscribe(
     ( response:HttpResponse<any>) => { localStorage.setItem('currentUser',loginPacient.UserName);this.router.navigateByUrl('programare')},
     ( error )=> { this.errorMessage = "Incorrect email or password!"},
    );
  }

}
