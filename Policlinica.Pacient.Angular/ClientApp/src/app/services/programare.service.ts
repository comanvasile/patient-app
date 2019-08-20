import { Injectable } from '@angular/core';

import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { LoginPacient } from '../models/login.pacient';
import { Programare } from '../models/programare';

@Injectable({
    providedIn: 'root'
  })
export class ProgramareService{
    private loginUrl="http://localhost:8080/login";
    redirectUrl:string;
    headers: HttpHeaders = new HttpHeaders({ 'Content-Type': 'application/json' });
    constructor(private http:HttpClient){

    }
    createProgramare (programare: Programare):Observable<any> {
        return this.http.post<any>('/api/createprogramare',programare,{observe:'response'});
  }
  public getProgramari(user: string): Observable<Array<string>> {
    //const headers= new HttpHeaders({ 'Content-Type': 'application/json' , 'Authorization': JSON.stringify(localStorage.getItem('currentUser'))});
    return this.http.get<Array<string>>('/api/programari/' + user, { headers: this.headers });
       }
}
