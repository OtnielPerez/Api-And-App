import { TestBed } from '@angular/core/testing';

import { NEWSService } from './news.service';

describe('NEWSService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: NEWSService = TestBed.get(NEWSService);
    expect(service).toBeTruthy();
  });
});
