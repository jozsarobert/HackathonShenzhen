import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PieceDetailComponent } from './piece-detail.component';

describe('PieceDetailComponent', () => {
  let component: PieceDetailComponent;
  let fixture: ComponentFixture<PieceDetailComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PieceDetailComponent]
    });
    fixture = TestBed.createComponent(PieceDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
