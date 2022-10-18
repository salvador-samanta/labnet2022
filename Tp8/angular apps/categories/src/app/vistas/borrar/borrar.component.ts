// import { Component, OnInit } from '@angular/core';

// @Component({
//   selector: 'app-borrar',
//   templateUrl: './borrar.component.html',
//   styleUrls: ['./borrar.component.css']
// })
// export class BorrarComponent implements OnInit {

//   constructor() { }

//   ngOnInit(): void {
//   }

// }

import { Component, OnInit } from '@angular/core';
import {Router, ActivatedRoute} from '@angular/router';
import { CategoriesListaInterface } from '../../modelos/listaCategories.interface'
import { ApiService } from '../../servicios/api/api.service';
import { FormGroup,FormControl,Validators,AbstractControl,FormBuilder} from '@angular/forms';
import { CategoriesListaComponent } from '../categories-lista/categories-lista.component';


@Component({
  selector: 'app-delete',
  templateUrl: './borrar.component.html',
  styleUrls: ['./borrar.component.css']
})
export class BorrarComponent implements OnInit {

  constructor(private activeRouter:ActivatedRoute, private router:Router, private api:ApiService, private fb:FormBuilder) { }
  
  datosCategory!: CategoriesListaInterface;
  borrarCategory!:FormGroup;
  
  ngOnInit(): void {
    this.borrarCategory = this.fb.group({
      Id: ['']
    })
    let CategoryId = this.activeRouter.snapshot.paramMap.get('id');
    this.api.getSingleCategory(CategoryId).subscribe(data =>{
      this.datosCategory = data;
      this.borrarCategory.setValue({
       'Id' : this.datosCategory.Id,
       'Name': this.datosCategory.Name,
       'Description': this.datosCategory.Description
      });
    })  
  }
  eliminar(id: any){
    this.api.deleteCategory(id).subscribe(data =>{
       this.router.navigate(["categories-lista"])
    } );
   }

   
  linkLista(){
    this.router.navigate(['categories-lista'])
  }
}