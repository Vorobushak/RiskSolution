import { Injectable } from '@angular/core';
import { Observable, mergeMap } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { IViolationBase } from "./models/violationBase";

@Injectable({
  providedIn: 'root'
})
export class SearchService {

  apiPath = 'http://localhost:5299/api/';
  constructor(private http: HttpClient) { }

  // SearchAllViolations(field: string, value: string): Observable<IViolationBase> {
  //   return this.SearchAccessibilityViolation(field, value).pipe(mergeMap)
  // }

  SearchIntegrityViolation(field: string, value: string): Observable<IViolationBase[]> {
    return this.http.post<IViolationBase[]>(this.apiPath + 'integrity', {field, value});
  }

  SearchConfidentialityViolation(field: string, value: string): Observable<IViolationBase[]> {
    return this.http.post<IViolationBase[]>(this.apiPath + 'confidentiality', {field, value});
  }

  SearchAccessibilityViolation(field: string, value: string): Observable<IViolationBase[]> {
    return this.http.post<IViolationBase[]>(this.apiPath + 'accessibility', {field, value});
  }
}


