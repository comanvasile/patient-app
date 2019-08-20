import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { Programare } from 'src/app/models/programare';
import { UnitateMedicala } from 'src/app/models/unitate';
import { UnitateService } from 'src/app/services/unitate.service';
import { MedicService } from 'src/app/services/medic.service';
import { SpecialitateService } from 'src/app/services/specialitate.service';
import { ProgramareService } from 'src/app/services/programare.service';
import { MatDialogConfig, MatDialog } from '@angular/material';
import { DialogComponent } from '../dialog/dialog.component';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-adaugare',
  templateUrl: './adaugare.component.html',
  styleUrls: ['./adaugare.component.scss']
})
export class AdaugareComponent implements OnInit {
  addForm: FormGroup;
  title: string;
  buttonTitle: string;
  editMode: boolean;
  errorMessage: string;
  unitList:Array<UnitateMedicala> = new Array<UnitateMedicala>();
  medicList:Array<string>=new Array<string>();
  specialitatiList:Array<string>=new Array<string>();
  username:string;
  constructor(public datepipe:DatePipe,public dialog:MatDialog,private fb:FormBuilder,private router:Router,private activatedRoute: ActivatedRoute,private unitService:UnitateService,private medicService:MedicService,private specialitateService:SpecialitateService,private programareService:ProgramareService) { }

  ngOnInit() {
    
    this.username=localStorage.getItem('currentUser');
    this.activatedRoute.params.subscribe(params => {
      const id = params.id;
      if (id) {
       
        this.title = "Editeaza Programare";
        this.editMode = true;
        this.buttonTitle = "Edit";
        
      } else {
        this.createForm();
        this.title = "Creeaza Programare";
        this.editMode = false;
        this.buttonTitle = "Create";
      }
    });
  }
  createForm(programare?: Programare) {
    
    this.addForm = this.fb.group({
      unitControl: [programare ? programare.UnitateMedicala : '',[ Validators.required]],
      specialitateControl:[programare ? programare.Specialitate:'',[Validators.required]],
      date:['',[Validators.required]],
      medicControl:[programare ? programare.Medic:'',[Validators.required]],
      timeControl:['',[Validators.required]]
    });
    this.unitService.getUnits().subscribe(r => {
     
      this.unitList = r;
      
    })

    this.medicService.getMedici(this.addForm.value.unitControl).subscribe(r=>{
      this.medicList=r;
    })
    this.specialitateService.getSpecialitati(this.addForm.value.medicControl).subscribe(r=>{
      this.specialitatiList=r;
    })
    
  }
  changeState(){
    this.medicService.getMedici(this.addForm.value.unitControl).subscribe(r=>{
      this.medicList=r;
    })
    
  }
  changeState2(){
    this.specialitateService.getSpecialitati(this.addForm.value.medicControl).subscribe(r=>{
      this.specialitatiList=r;
    })
  }

  cancel(){
    this.router.navigateByUrl('programare');
  }
  updateOrCreateProgramare(){
  
    const programare=new Programare(this.addForm.value.unitControl,this.addForm.value.medicControl,this.addForm.value.specialitateControl,  this.datepipe.transform(this.addForm.value.date, 'dd-MM-yyyy')+" "+this.addForm.value.timeControl,this.username)
    this.programareService.createProgramare(programare).subscribe(
      r=>{
        this.router.navigateByUrl('programare');
        const dialogConfig=new MatDialogConfig();
        dialogConfig.data={
          message:'Programare facuta cu succes'
          
        }
        const dialogRef = this.dialog.open(DialogComponent,
        dialogConfig);
        


      },
      e=>{
        const dialogConfig=new MatDialogConfig();
        dialogConfig.data={
          message:'Nu se poate efectua programarea!'
          
        }
        const dialogRef = this.dialog.open(DialogComponent,
        dialogConfig);
        

    }
      
    );
  }

}
