import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MaterialModule } from './material/material.module';
import { DlDateTimePickerDateModule } from 'angular-bootstrap-datetimepicker';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { CreateComponent } from './components/create/create.component';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FlexLayoutModule } from "@angular/flex-layout";
import { MainpageComponent } from './components/mainpage/mainpage.component';
import { AdaugareComponent } from './components/adaugare/adaugare.component';
import { HeaderComponent } from './components/header/header.component';
import {MatDatepickerModule} from '@angular/material/datepicker'
import { MatNativeDateModule } from '@angular/material';
import {NgxMaterialTimepickerModule} from 'ngx-material-timepicker';
import { HttpClientModule } from '@angular/common/http';
import { LoginService } from './services/login.service';
import { AccountService } from './services/account.service';
import { DialogComponent } from './components/dialog/dialog.component';
import { MessageComponent } from './components/message/message.component';
import { DatePipe } from '@angular/common';
import { AuthGuard } from './auth/auth';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    CreateComponent,
    MainpageComponent,
    AdaugareComponent,
    HeaderComponent,
    DialogComponent,
    MessageComponent,
  
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MaterialModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    FlexLayoutModule,
    DlDateTimePickerDateModule,
    MatDatepickerModule,
    MatNativeDateModule,
    NgxMaterialTimepickerModule.forRoot(),
    HttpClientModule,

  ],
  entryComponents:[DialogComponent],
  providers: [LoginService,AccountService,DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
