import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipmentsOverviewComponent } from './shipments-overview.component';

describe('ShipmentsOverviewComponent', () => {
  let component: ShipmentsOverviewComponent;
  let fixture: ComponentFixture<ShipmentsOverviewComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ShipmentsOverviewComponent]
    });
    fixture = TestBed.createComponent(ShipmentsOverviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
