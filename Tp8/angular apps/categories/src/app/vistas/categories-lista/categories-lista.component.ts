import { Component, OnInit } from '@angular/core';
import {ApiService} from '../../servicios/api/api.service';
import {Router} from '@angular/router';

import {CategoriesListaInterface} from '../../modelos/listaCategories.interface';

@Component({
  selector: 'app-categories-lista',
  templateUrl: './categories-lista.component.html',
  styleUrls: ['./categories-lista.component.css']
})
export class CategoriesListaComponent implements OnInit {
  categories!: CategoriesListaInterface[];
// a: any;
  constructor(private api:ApiService, private router:Router) { }  

  ngOnInit(): void {
    this.api.getCategoriesList().subscribe(data => {
      this.categories = data
      
    })
  }

  editarCategories(id){
    this.router.navigate(['editar', id])
  }

  borrarCategories(id){
    this.router.navigate(['borrar', id])
  }

  nuevaCategoria(){
    this.router.navigate(['nuevo']);
  }

}
