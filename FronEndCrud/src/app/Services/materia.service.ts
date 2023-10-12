import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from  'rxjs';
import { Materia } from '../Interfaces/materia';

@Injectable({
  providedIn: 'root'
})


export class MateriaService {
  private endPoint:string=environment.endPoint;
  private apirUrl:string=this.endPoint + "materia/";

  constructor(private http:HttpClient) { }

  getList():Observable<Materia[]>{
    return this.http.get<Materia[]>(`${this.apirUrl}lista`);
  }
}