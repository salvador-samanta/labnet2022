import { NgModule } from '@angular/core';

import {Routes, RouterModule} from '@angular/router';
import {CategoriesListaComponent} from './vistas/categories-lista/categories-lista.component';
import { BorrarComponent } from './vistas/borrar/borrar.component';
import { NuevoComponent } from './vistas/nuevo/nuevo.component';
import { EditarComponent } from './vistas/editar/editar.component';




const routes: Routes = [
  {path: '', redirectTo: 'categoryList' , pathMatch: 'full'},
  {path: 'categories-lista', component:CategoriesListaComponent},
  {path: 'borrar/:id', component:BorrarComponent},
  {path: 'nuevo', component:NuevoComponent},
  {path: 'editar/:id', component:EditarComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
export const routingComponents = [CategoriesListaComponent,NuevoComponent,EditarComponent,BorrarComponent]