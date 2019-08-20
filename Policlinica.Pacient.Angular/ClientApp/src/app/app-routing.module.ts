import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { CreateComponent } from './components/create/create.component';
import { MainpageComponent } from './components/mainpage/mainpage.component';
import { AdaugareComponent } from './components/adaugare/adaugare.component';
import { AuthGuard } from './auth/auth';

const routes: Routes = [
  {
    path:'',
    component:LoginComponent
  },
  {
    path:'login',
    component:LoginComponent
  },
  {
    path:'create',
    component:CreateComponent
  },
  {
    path:'programare',
    component:MainpageComponent,
    canActivate: [AuthGuard]
  },
  {
    path:'adaugare',
    component:AdaugareComponent,
    canActivate: [AuthGuard]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
