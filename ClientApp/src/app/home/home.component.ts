import { Component, OnInit, ViewChild } from '@angular/core';
import { EmployeeService } from '../employee.service';
import {CommonModule} from '@angular/common';
import { Employee } from '../employee';
import { FormControl } from '@angular/forms';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
employees : Employee[];
employeeData: Employee;
isUpdate:boolean = false;
  constructor(private employeeService : EmployeeService){
    this.employeeData = new Employee();
  }
  @ViewChild('addUserForm',{static: false}) form : any;
  ngOnInit(){
    this.employeeService.getAll().subscribe(data=>{
      console.log("datsdda",data);
      this.employees = data;
      this.isUpdate = false;
    })
  }

  addUser(employeeData: Employee){
    console.log("testcompo",employeeData);
    this.employeeService.createUser(employeeData).subscribe(res=>{
        this.ngOnInit();
    })
  }
  delete(id : any){
    console.log("delete",id)
    this.employeeService.deleteUser(id).subscribe(res=>{
      this.ngOnInit();
    })
  }
  onEdit(){
    this.isUpdate = true;
  }
  update(item: Employee){
   
    this.employeeService.updateUser(item).subscribe(data=>{
      this.ngOnInit();
      this.isUpdate = false;

    })
  }
}
