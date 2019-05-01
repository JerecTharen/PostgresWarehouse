import { TestBed, inject } from '@angular/core/testing';

import { DbCRUDService } from './db-crud.service';

describe('DbCRUDService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [DbCRUDService]
    });
  });

  it('should be created', inject([DbCRUDService], (service: DbCRUDService) => {
    expect(service).toBeTruthy();
  }));
});
