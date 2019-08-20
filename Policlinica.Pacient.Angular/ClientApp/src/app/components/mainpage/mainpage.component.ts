import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from 'src/app/services/login.service';
import { ProgramareService } from 'src/app/services/programare.service';
import { Programare } from 'src/app/models/programare';
import { MatTableDataSource } from '@angular/material';

@Component({
  selector: 'app-mainpage',
  templateUrl: './mainpage.component.html',
  styleUrls: ['./mainpage.component.scss']
})
export class MainpageComponent implements OnInit {
  displayedColumns: Array<string> = ['unitName', 'specialitateName', 'medicName', 'date', 'action'];
  public programariList;
  p: Programare;
  table: Array<any>;
  constructor(private router: Router, public loginService: LoginService, public programareService: ProgramareService) { }
  username: string;
  ngOnInit() {
    this.table = new Array<any>();
    this.username = localStorage.getItem('currentUser');
    this.programareService.getProgramari(this.username).subscribe(r => {
      for (var i = 0; i < r.length; i++) {
        var splited = r[i].split("@");
        console.log(splited);

        this.table.push({ unitName: splited[0], medicName: splited[1], specialitateName: splited[3], date: splited[4] });
      }
      console.log(this.table);
      this.programariList = new MatTableDataSource<Programare>(this.table);
    });
    //this.getProgramari();
    //this.programariList.push(new Programare('asd', 'asd', 'asd', 'asd', 'asd'));
    //this.programariList.push(new Programare('asd', 'asd', 'asd', 'asd', 'asd'));
    console.log(this.programariList);
  }
  getProgramari() {
    this.programareService.getProgramari(this.username).subscribe(r => {
      for (var i = 0; i < r.length; i++) {
        var splited = r[i].split("@");
        console.log(splited);
        
        this.table.push({unitName:splited[0], medicName:splited[1], specialitateName:splited[3], date:splited[4]});
      }
      console.log(this.table);
      this.programariList = new MatTableDataSource<Programare>(this.table);
      //console.log(this.programariList);
    })
  }
  creeazaProgramare() {
    this.router.navigateByUrl('adaugare');
  }
  logout() {
    this.router.navigateByUrl('login');
    this.loginService.logout();
  }
}
