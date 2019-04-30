import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FetchInventoryComponent } from './fetch-inventory.component';

describe('FetchInventoryComponent', () => {
  let component: FetchInventoryComponent;
  let fixture: ComponentFixture<FetchInventoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FetchInventoryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FetchInventoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
