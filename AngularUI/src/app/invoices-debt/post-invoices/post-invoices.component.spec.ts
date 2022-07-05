import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PostInvoicesComponent } from './post-invoices.component';

describe('PostInvoicesComponent', () => {
  let component: PostInvoicesComponent;
  let fixture: ComponentFixture<PostInvoicesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PostInvoicesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PostInvoicesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
