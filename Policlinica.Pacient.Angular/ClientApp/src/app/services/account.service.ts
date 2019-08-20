import { Injectable, Inject } from '@angular/core';

import { HttpHeaders,HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { LoginPacient } from '../models/login.pacient';
import { Pacient } from '../models/pacient';

@Injectable({
    providedIn: 'root'
  })
export class AccountService{
    private accountUrl="http://localhost:8080/api/create";
    redirectUrl:string;
    headers: HttpHeaders = new HttpHeaders({ 'Content-Type': 'application/json' });

    myAppUrl: string = "";  
    // constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {  
    //     this.myAppUrl = baseUrl;  
    // }  
    constructor(private http:HttpClient){
        
    }
    addPacient(pacient: Pacient): any {
      // let body = JSON.stringify({ firstName:pacient.Pr,lastName:pacient.lastName,cnp:pacient.cnp,email:pacient.email,cnas:pacient.cnas,job:pacient.job });
       return this.http.post<Pacient>('/api/create', pacient, { headers: this.headers })
         //return this.http.post<Pacient>('/api/create',"vasi are mere",{headers:this.headers})
      }
    addLogin(login:LoginPacient): any{
        console.log(login);
        return this.http.post<LoginPacient>('/api/createlogin',login,{headers:this.headers});
    }
}