import { Component, OnInit } from '@angular/core';
import { ReasonDetailService } from 'src/app/share/reason-detail.service';
import { NgForm} from '@angular/forms';
import { Message } from '@angular/compiler/src/i18n/i18n_ast';

//import {Popup} from 'ng2-opd-popup';

@Component({
  selector: 'app-reason-detail',
  templateUrl: './reason-detail.component.html',
  styleUrls: ['./reason-detail.component.css']
})
export class ReasonDetailComponent implements OnInit {

  constructor(private service:ReasonDetailService) { }
  
  alert:boolean=false;
  error:boolean=false;


  

  ngOnInit() {
    this.resetForm()
    this.alert=false;
    this.error=false;
  }

resetForm(form?:NgForm)
{
  if(form!=null)
  form.resetForm();
  this.service.formdata=
  {
    id1:0,
    startdate2:'',
    enddate2:'',
    process2:'',
    reason2:''




  }
}
onsubmit(form:NgForm)
{
  
  

  this.service.postresondetails(form.value).subscribe(
    res => {
    this.alert=true;
    this.error=false;
      this.resetForm(form);
    },
    err =>{
      this.error=true;
      this.alert=false;
     
    }
  )
  

 
}
closeAlert()
{
  this.alert=false;
}
close()
{
  this.error=false;
}



}
