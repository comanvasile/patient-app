import { Injectable } from '@angular/core';

import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { LoginPacient } from '../models/login.pacient';
import { UnitateMedicala } from '../models/unitate';

@Injectable({
    providedIn: 'root'
  })
export class SpecialitateService{
    
    headers: HttpHeaders = new HttpHeaders({ 'Content-Type': 'application/json' });

    constructor(private http:HttpClient){

    }
    public getSpecialitati(denumire:string): Observable<Array<string>> {
        //const headers= new HttpHeaders({ 'Content-Type': 'application/json' , 'Authorization': JSON.stringify(localStorage.getItem('currentUser'))});
         return this.http.get<Array<string>>('/api/specialitati/'+denumire, { headers: this.headers });
       }
}