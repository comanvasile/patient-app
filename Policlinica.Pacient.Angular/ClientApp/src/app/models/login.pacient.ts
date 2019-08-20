export class LoginPacient{
    FkPacientId:Number;
    UserName:string;
    Parola:String;
    DataInregistrare:Date;
    constructor(username:string,password:string){
           
            this.UserName=username;
            this.Parola=password;
    }
}