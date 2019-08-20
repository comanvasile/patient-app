import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Pacient } from 'src/app/models/pacient';
import { LoginPacient } from 'src/app/models/login.pacient';
import { AccountService } from 'src/app/services/account.service';
import { MatDialogConfig, MatDialog } from '@angular/material';
import { DialogComponent } from '../dialog/dialog.component';
import { combineLatest } from 'rxjs';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent implements OnInit {
  addUserFormGroup: FormGroup;
  addContFormGroup: FormGroup;
  hide=true;
  constructor(private fb:FormBuilder,private fb2:FormBuilder,private router:Router,private accountService:AccountService,public dialog:MatDialog) { }

  ngOnInit() {
    this.addUserFormGroup=this.fb.group({
      firstNameControl:['',[Validators.required,Validators.pattern(new RegExp("[A-Z|a-z]"))]],
      lastNameControl:['',[Validators.required,Validators.pattern(new RegExp("[A-Za-z]"))]],
      cnpControl:['',[Validators.required,Validators.pattern(new RegExp("[1-9]"))]],
     
      cardControl:['',[Validators.required,Validators.pattern(new RegExp("[0-9]"))]],
      jobControl:['',[Validators.required]],
      emailControl:['',[Validators.required,Validators.email]]
    });
    this.addContFormGroup=this.fb2.group({
      passwordControl:['',[Validators.required]],
      usernameControl:['',[Validators.required]],
    })
  }
  cancel(){
    this.router.navigateByUrl('login');
  }
  save(){

    const pacient=new Pacient(this.addUserFormGroup.value.firstNameControl,this.addUserFormGroup.value.lastNameControl,this.addUserFormGroup.value.cnpControl,this.addUserFormGroup.value.emailControl,this.addUserFormGroup.value.cardControl,this.addUserFormGroup.value.jobControl);
    console.log(pacient);
    this.accountService.addPacient(pacient).subscribe(
      r=>{  
        
        const dialogConfig=new MatDialogConfig();
        dialogConfig.data={
          message:'Pacient adaugat cu succes!'
          
        }
        const dialogRef = this.dialog.open(DialogComponent,
        dialogConfig);

      },
      error=>{
        const dialogConfig=new MatDialogConfig();
              dialogConfig.data={
                message:'Nu se poate adauga pacientul!'
                
              }
              const dialogRef = this.dialog.open(DialogComponent,
              dialogConfig);
              

      }
     );
    
      

     
     
  }
  saveCont()
  {
    const credentials=new LoginPacient(this.addContFormGroup.value.usernameControl,this.addContFormGroup.value.passwordControl);

    this.accountService.addLogin(credentials).subscribe(
      r=>{
        this.router.navigateByUrl("login");
        const dialogConfig=new MatDialogConfig();
        dialogConfig.data={
          message:'Succes'
          
        }
        const dialogRef = this.dialog.open(DialogComponent,
        dialogConfig);
        
      },
      e=>{
        const dialogConfig=new MatDialogConfig();
        dialogConfig.data={
          message:'This account cannot be adeed! Please try again!'
          
        }
        const dialogRef = this.dialog.open(DialogComponent,
        dialogConfig);
        
      }
    );
  }
}
