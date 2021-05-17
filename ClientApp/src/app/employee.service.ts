import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Data } from '@angular/router';
import { Observable } from 'rxjs';
import { Employee } from './employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http: HttpClient) { }

  getAll():Observable<any>{
    const url = "https://localhost:44371/api/Employee";
    return this.http.get<any>(url);
  }

  createUser(data : Employee):Observable<any>{
    console.log("data",data.name)
    const url = "https://localhost:44371/api/Employee";
    return this.http.post<Employee>(url,data);
  }

  deleteUser(id : any):Observable<any>{
    const url = "https://localhost:44371/api/Employee"+'/' +id;
    return this.http.delete<any>(url);
  }

  updateUser(data: Employee):Observable<any>{
    const url = "https://localhost:44371/api/Employee";
    return this.http.put<Employee>(url,data);
  }
}
