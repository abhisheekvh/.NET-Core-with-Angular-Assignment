import { Injectable } from '@angular/core';
import { ReasonDetail } from './reason-detail.model';
import {HttpClient} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class ReasonDetailService {
  formdata:ReasonDetail; 
  readonly rooturl='http://localhost:62860/api'

  constructor(private http:HttpClient) { }


  postresondetails(formdata:ReasonDetail)
  {
return this.http.post(this.rooturl+'/reasondetail',formdata)
  }
}
