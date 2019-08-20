import { LoginPacient } from './login.pacient';

export class Pacient{
    PacientId:number;
    Prenume:string;
    Nume:string;
    CNP:string;
    Email:string;
    CardSanatate:string;
    Ocupatie:string;
   // LoginPacient:LoginPacient;
    constructor(firstName:string,lastName:string,cnp:string,email:string,cnas:string,job:string){
        this.Prenume=firstName;
        this.Nume=lastName;
        this.CNP=cnp;
        this.CardSanatate=cnas;
        this.Email=email;
        this.Ocupatie=job;
        
    }
}