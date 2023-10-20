import { Component, OnInit } from '@angular/core';

import { FormBuilder,FormGroup,Validators } from '@angular/forms';
import {MatDialogRef} from '@angular/material/dialog';
import {MatSnackBar} from '@angular/material/snack-bar';
import * as moment from 'moment';

import { Estudiante } from 'src/app/Interfaces/estudiante';
import { Materia } from 'src/app/Interfaces/materia';
import { EstudianteService } from 'src/app/Services/estudiante.service';
import { MateriaService } from 'src/app/Services/materia.service';



@Component({
  selector: 'app-dialogo-add-edit',
  templateUrl: './dialogo-add-edit.component.html',
  styleUrls: ['./dialogo-add-edit.component.css']
})
export class DialogoAddEditComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
