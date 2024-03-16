import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PiecesOverviewComponent } from './pieces-overview.component';

describe('PiecesOverviewComponent', () => {
  let component: PiecesOverviewComponent;
  let fixture: ComponentFixture<PiecesOverviewComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PiecesOverviewComponent]
    });
    fixture = TestBed.createComponent(PiecesOverviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
