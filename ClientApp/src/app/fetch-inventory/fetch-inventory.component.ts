import { Component, OnInit, Inject } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-fetch-inventory',
  templateUrl: './fetch-inventory.component.html',
  styleUrls: ['./fetch-inventory.component.css']
})
export class FetchInventoryComponent implements OnInit {

  public inventory: any[];
  public getInventory: Observable<any>;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    // http.get<any[]>(baseUrl + 'api/InventoryData/AllItems').subscribe((items)=>{
    //   console.log(items);
    //   this.inventory = items;
    // });
    this.getInventory = http.get<any[]>(baseUrl + 'api/InventoryData/AllItems');
   }

  ngOnInit() {
  }

}
