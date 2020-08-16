import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReasonDetailComponent } from './reason-detail.component';

describe('ReasonDetailComponent', () => {
  let component: ReasonDetailComponent;
  let fixture: ComponentFixture<ReasonDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReasonDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReasonDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
