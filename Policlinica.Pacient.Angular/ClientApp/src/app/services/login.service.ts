import { Injectable } from '@angular/core';

import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { LoginPacient } from '../models/login.pacient';

@Injectable({
    providedIn: 'root'
  })
export class LoginService{
    private loginUrl="http://localhost:8080/login";
    redirectUrl:string;
    headers: HttpHeaders = new HttpHeaders({ 'Content-Type': 'application/json' });
    constructor(private http:HttpClient){

    }
    submitLogin (login: LoginPacient):Observable<any> {
        return this.http.post<any>('/api/login',login,{observe:'response'});
     }
     logout() {
        localStorage.removeItem('currentUser');
    }
}