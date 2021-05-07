import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Opera } from './opera';

@Injectable({
  providedIn: 'root'
})
export class OperaService {

  constructor(private http: HttpClient) { }

  getAllOperas(): Observable<Opera[]>{
    return this.http
      .get<Opera[]>('http://localhost:5000/api/operas');
  }

  getOpera(id: number): Observable<Opera>{
    return this.http
      .get<Opera>('http://localhost:5000/api/operas/' + id);
  }

  insertOperas(opera: Opera): Observable<Opera>{
    return this.http
      .post<Opera>('http://localhost:5000/api/operas/', opera);
  }

  updateOperas(opera: Opera): Observable<void>{
    return this.http
      .put<void>('http://localhost:5000/api/operas/' + opera.operaID, opera);
  }

  deleteOpera(id: number){
    return this.http
      .delete('http://localhost:5000/api/operas/' + id);
  }
}
