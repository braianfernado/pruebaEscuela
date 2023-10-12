import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from  'rxjs';
import { Estudiante } from  '../Interfaces/estudiante';


@Injectable({
  providedIn: 'root'
})
export class EstudianteService {

  private endPoint:string=environment.endPoint;
  private apirUrl:string=this.endPoint + "estudiante/";

  constructor(private http:HttpClient) { }

  getList():Observable<Estudiante[]>{
    return this.http.get<Estudiante[]>(`${this.apirUrl}lista`);
   }

add(modelo:Estudiante):Observable<Estudiante>{

  return this.http.post<Estudiante>(`${this.apirUrl}guardar`,modelo);
}


update(EstudianteID:number,modelo:Estudiante):Observable<Estudiante>{
  return this.http.post<Estudiante>(`${this.apirUrl}actualizar/${EstudianteID}`,modelo);
}

delete(EstudianteID:number):Observable<void>{
  return this.http.delete<void>(`${this.apirUrl}eliminar/${EstudianteID}`);
}


}
