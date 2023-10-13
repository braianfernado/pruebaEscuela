import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
// para trabajar con reative from
import{ReactiveFormsModule}from'@angular/forms';
// para trabajar con peticiones http
import{HttpClientModule}from '@angular/common/http';
// para trabajar con tablas material
import {MatTableModule} from '@angular/material/table';
import {MatPaginatorModule} from '@angular/material/paginator';
// para trabajar con controles de formulario
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import {MatSelectModule} from '@angular/material/select';
import {MatButtonModule} from '@angular/material/button';
// para trabajar con alertas
import {MatSnackBarModule} from '@angular/material/snack-bar';
// para trabajar con iconos material
import {MatIconModule} from '@angular/material/icon';
// para trabajar con dialogos
import {MatDialogModule} from '@angular/material/dialog';
// para trabajar con cuadrillas
import {MatGridListModule} from '@angular/material/grid-list';
import { DialogoAddEditComponent } from './Dialogs/dialogo-add-edit/dialogo-add-edit.component';


@NgModule({
  declarations: [
    AppComponent,
    DialogoAddEditComponent
  ],
  imports: [
    BrowserModule,MatFormFieldModule,MatInputModule,
    BrowserAnimationsModule,MatSelectModule,
    MatButtonModule,MatSnackBarModule,
    MatTableModule,MatIconModule,
    MatPaginatorModule,MatDialogModule,
    ReactiveFormsModule,MatGridListModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
