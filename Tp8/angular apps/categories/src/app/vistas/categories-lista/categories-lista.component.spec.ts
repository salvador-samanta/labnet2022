import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CategoriesListaComponent } from './categories-lista.component';

describe('CategoriesListaComponent', () => {
  let component: CategoriesListaComponent;
  let fixture: ComponentFixture<CategoriesListaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CategoriesListaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CategoriesListaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
