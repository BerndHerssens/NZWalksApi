import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RegionService {

  private APIUrl = 'http://localhost:5162/api/Regions/GetAllRegions?incloudWalks=false';
  private key = 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6Ikpvc0BtYWdhemlqbi5jb20iLCJuYW1lIjoiSm9zIERlIE1hZ2F6aWpuaWVyIiwiSG9iYnkiOiJEb3plbiB2ZXJzbGVwZW4iLCJuYmYiOjE3MTU5NDc3OTcsImV4cCI6MTcxNTk1MTM5NywiaWF0IjoxNzE1OTQ3Nzk3LCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjUxNjIvIiwiYXVkIjoiaHR0cDovL2xvY2FsaG9zdDo1MTYyLyJ9.rKkg31376-w8zZb48IPhbXdF0B2oGAPBD2mRNZ5_wHg'
  
  getRegions() : Observable<any>{
    const headers = new HttpHeaders({
      Authorization: `bearer ${this.key}`
    })


    return this.HttpClient.get(this.APIUrl,{headers});
  }

  constructor(private HttpClient : HttpClient) { }
}
