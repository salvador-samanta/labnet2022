import { Component, OnInit } from '@angular/core';
import {Router, ActivatedRoute} from '@angular/router';
import { CategoriesListaInterface } from '../../modelos/listaCategories.interface'
import { ApiService } from '../../servicios/api/api.service';
import { FormGroup,FormControl,Validators,AbstractControl,FormBuilder} from '@angular/forms';
import { CategoriesListaComponent } from '../categories-lista/categories-lista.component';


@Component({
  selector: 'app-editar',
  templateUrl: './editar.component.html',
  styleUrls: ['./editar.component.css']
})
export class EditarComponent implements OnInit {

  constructor(private activatedRouter:ActivatedRoute , private router: Router, private api:ApiService, private fb:FormBuilder) { }

  datosCategory!:CategoriesListaInterface;
  editarCategory!:FormGroup;

  

  ngOnInit(): void {
      this.editarCategory = this.fb.group({
        Description: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(30), Validators.pattern(/^[ a-zA-ZñÑáéíóúÁÉÍÓÚ]+$/)]],
        Id: [''],
        Name: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(30), Validators.pattern(/^[ a-zA-ZñÑáéíóúÁÉÍÓÚ]+$/)]]
        
      })


     let datosCategory = this.activatedRouter.snapshot.paramMap.get('id');

     this.api.getSingleCategory(datosCategory).subscribe(data=>
      {console.log(data);
      this.datosCategory = data;
        this.editarCategory.setValue({
          'description' : this.datosCategory.Description,
          'id' : this.datosCategory.Id,
          'name' : this.datosCategory.Name,
        })
     })

  }

  postForm(forms:CategoriesListaInterface){
    this.api.AddCategory(forms).subscribe(data => {
      (this.editarCategory.valid)
      this.router.navigate(['categories-lista'])
    })
  }
  
  linkLista(){
    this.router.navigate(['categories-lista'])
  }


}
