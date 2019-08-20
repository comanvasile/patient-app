import { UnitateMedicala } from './unitate';
import { Medic } from './medic';
import { Specialitate } from './specialitate';

export class Programare{
    UnitateMedicala:string;
    Medic:string;
    Specialitate:string;
    Data:string;
    Pacient:string;
    constructor(u:string,m:string,specialitate:string,data:string,p:string)
    {
        this.UnitateMedicala=u;
        this.Medic=m;
        this.Specialitate=specialitate
        this.Data=data;
        this.Pacient=p;
    }
}
