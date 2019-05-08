import { Component, OnInit, inject } from '@angular/core';
import { DbCRUDService } from '../Services/db-crud.service';
import {InventoryItem} from '../DataModels/inventory-item';

@Component({
  selector: 'app-add-item',
  templateUrl: './add-item.component.html',
  styleUrls: ['./add-item.component.css']
})
export class AddItemComponent implements OnInit {

  private name: string;
  private ailse: number;
  private shelf: number;
  private quantity: number;
  private db: DbCRUDService;

  constructor(db: DbCRUDService) {
    this.db = db;
   }

  ngOnInit() {
  }

  submitItem(): void{
    let item: InventoryItem = {
      name: this.name,
      ailse: this.ailse,
      shelf: this.shelf,
      quantity: this.quantity
    }
    this.db.AddItem(item);
  }

}
