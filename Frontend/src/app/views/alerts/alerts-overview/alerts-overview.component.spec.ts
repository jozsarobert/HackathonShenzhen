import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AlertsOverviewComponent } from './alerts-overview.component';

describe('AlertsOverviewComponent', () => {
  let component: AlertsOverviewComponent;
  let fixture: ComponentFixture<AlertsOverviewComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AlertsOverviewComponent]
    });
    fixture = TestBed.createComponent(AlertsOverviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
