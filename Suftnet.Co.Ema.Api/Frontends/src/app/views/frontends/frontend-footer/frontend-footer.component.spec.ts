import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FooterFrontendComponent } from './frontend-footer.component';

describe('FooterFrontendComponent', () => {
  let component: FooterFrontendComponent;
  let fixture: ComponentFixture<FooterFrontendComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FooterFrontendComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FooterFrontendComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
