import { Component, OnInit, Inject } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { DbCRUDService } from '../Services/db-crud.service';
import {InventoryItem} from "../DataModels/inventory-item"

@Component({
  selector: 'app-fetch-inventory',
  templateUrl: './fetch-inventory.component.html',
  styleUrls: ['./fetch-inventory.component.css']
})
export class FetchInventoryComponent implements OnInit {

  private db: DbCRUDService;
  private getInventory: Observable<InventoryItem[]>;

  constructor(db: DbCRUDService) {
    // http.get<any[]>(baseUrl + 'api/InventoryData/AllItems').subscribe((items)=>{
    //   console.log(items);
    //   this.inventory = items;
    // });
    this.db = db;
    this.getInventory = this.db.getAll();
    // this.getInventory = http.get<any[]>(baseUrl + 'api/InventoryData/AllItems');
   }

  ngOnInit() {
  }

}
