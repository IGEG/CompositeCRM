import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InvoicesDebtComponent } from './invoices-debt.component';

describe('InvoicesDebtComponent', () => {
  let component: InvoicesDebtComponent;
  let fixture: ComponentFixture<InvoicesDebtComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InvoicesDebtComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InvoicesDebtComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
