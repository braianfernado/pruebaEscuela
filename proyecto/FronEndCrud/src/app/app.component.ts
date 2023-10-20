import {AfterViewInit, Component, ViewChild} from '@angular/core';
import {MatPaginator, MatPaginatorModule} from '@angular/material/paginator';
import {MatTableDataSource, MatTableModule} from '@angular/material/table';
import { Estudiante } from './Interfaces/estudiante';
import { EstudianteService } from './Services/estudiante.service';

import {MatDialog, MatDialogModule} from '@angular/material/dialog';
import { DialogoAddEditComponent } from './Dialogs/dialogo-add-edit/dialogo-add-edit.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements AfterViewInit{
  displayedColumns: string[] = ['Nombre','Acciones'];
  dataSource = new MatTableDataSource<Estudiante>();
constructor(
  private _estudianteServicio:EstudianteService,public dialog: MatDialog)
  {

  }

  ngOnInit(): void {
    this.mostrarEstudiantes();
  }

  
  mostrarEstudiantes(){
    this._estudianteServicio.getList().subscribe({
      next:(dataResponse)=>{
        console.log(dataResponse)
        this.dataSource.data=dataResponse;
      },error:(e)=>{}
    })
  }

  dialogoNuevoEstudiante() {
    this.dialog.open(DialogoAddEditComponent);
  }

  @ViewChild(MatPaginator) paginator!: MatPaginator;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }


}
