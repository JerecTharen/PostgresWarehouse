import { Component, OnInit, Inject, Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { InventoryItem } from '../DataModels/inventory-item';

@Injectable({
  providedIn: 'root'
})
export class DbCRUDService {

  http: HttpClient;
  baseUrl: string;

  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string
  ) {
      this.http = http;
      this.baseUrl = baseUrl;
   }

   getAll(): Observable<InventoryItem[]>{
     return this.http.get<InventoryItem[]>(this.createUrl('api/InventoryData/AllItems'));
   }
   getByName(name: string): Observable<InventoryItem>{
     return this.http.get<InventoryItem>(this.createUrl(`api/InventoryData/ByName?name=${name}`));
   }
   getById(id: number): Observable<InventoryItem>{
     return this.http.get<InventoryItem>(this.createUrl(`api/InventoryData/ById?id=${id}`));
   }

   AddItem(item: InventoryItem): Observable<InventoryItem>{
     return this.http.post<InventoryItem>(this.createUrl('api/InventoryData/AddItem'),item);
   }

   createUrl(url: string): string{
     return this.baseUrl + url;
   }

}
