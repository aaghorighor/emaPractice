import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FrontendThemeComponent } from './frontend-theme.component';

describe('FrontendThemeComponent', () => {
  let component: FrontendThemeComponent;
  let fixture: ComponentFixture<FrontendThemeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FrontendThemeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FrontendThemeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
