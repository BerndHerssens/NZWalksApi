import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

export interface Region {
  Name: string;
  Beschrijving?: string;
  Beautygrade: number;
}

@Injectable({
  providedIn: 'root',
})
export class RegionService {
  private APIUrl =
    'http://localhost:5162/api/Regions/GetAllRegions?incloudWalks=false';
  private key =
    'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6Ikpvc0BtYWdhemlqbi5jb20iLCJuYW1lIjoiSm9zIERlIE1hZ2F6aWpuaWVyIiwiSG9iYnkiOiJEb3plbiB2ZXJzbGVwZW4iLCJuYmYiOjE3MTU5NTE0NTUsImV4cCI6MTcxNTk1NTA1NSwiaWF0IjoxNzE1OTUxNDU1LCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjUxNjIvIiwiYXVkIjoiaHR0cDovL2xvY2FsaG9zdDo1MTYyLyJ9.CxyuFNXsMzcJlqTeebGco3UzGQD7sXqeiFnmNFrrHC8';

  getRegions(): Observable<any> {
    const headers = new HttpHeaders({
      Authorization: `bearer ${this.key}`,
    });

    return this.HttpClient.get(this.APIUrl, { headers });
  }

  addRegion() {
    const headers = new HttpHeaders({
      Authorization: `bearer ${this.key}`,
    });

    const region: Region = {
      Name: 'ur mom',
      Beschrijving: 'no u',
      Beautygrade: 0,
    };

    return this.HttpClient.post('http://localhost:5162/api/Regions', region, {
      headers,
    });
  }

  constructor(private HttpClient: HttpClient) {}
}
