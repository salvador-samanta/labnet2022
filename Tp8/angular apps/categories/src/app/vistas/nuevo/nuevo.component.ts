import { Component, OnInit } from '@angular/core';
import {Router, ActivatedRoute} from '@angular/router';
import { CategoriesListaInterface } from '../../modelos/listaCategories.interface'
import { ApiService } from '../../servicios/api/api.service';
import { FormGroup,FormControl,Validators,AbstractControl,FormBuilder} from '@angular/forms';
import { CategoriesListaComponent } from '../categories-lista/categories-lista.component';


@Component({
  selector: 'app-nuevo',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.css']
})
export class NuevoComponent implements OnInit {

  constructor(private activeRouter:ActivatedRoute, private router:Router, private api:ApiService, private fb:FormBuilder) { }

  datosCategory!: CategoriesListaInterface;
  nuevoCategories!:FormGroup;

  ngOnInit(): void {
    this.nuevoCategories = this.fb.group({
      Name: [''],
      Description: ['']
    }) 
  }
  
  postForm(forms:CategoriesListaInterface){
    this.api.AddCategory(forms).subscribe(data => {
      (this.nuevoCategories.valid)
      this.router.navigate(['categories-lista'])
    })
  }

  
  linkLista(){
    this.router.navigate(['categories-lista'])
  }


}
