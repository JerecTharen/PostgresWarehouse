import { Component, OnInit, Inject, Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DbCRUDService {

  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string
  ) {
    
   }
}
