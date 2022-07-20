import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PostDocumentComponent } from './post-document.component';

describe('PostDocumentComponent', () => {
  let component: PostDocumentComponent;
  let fixture: ComponentFixture<PostDocumentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PostDocumentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PostDocumentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
