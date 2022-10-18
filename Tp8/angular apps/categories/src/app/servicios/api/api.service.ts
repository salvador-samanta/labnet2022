import { Injectable } from '@angular/core';
import{CategoriesListaInterface} from '../../modelos/listaCategories.interface'



import { HttpClient , HttpHeaders } from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  url:string = "https://localhost:44395/";

  constructor(private http:HttpClient) {}

  getCategoriesList():Observable<CategoriesListaInterface[]>
  {
    let direccion = this.url + "api/Categories";
    return this.http.get<CategoriesListaInterface[]>(direccion);
  }

  AddCategory(form:CategoriesListaInterface):Observable<CategoriesListaInterface>
  {
    let direccion = this.url + "api/categories/";
    return this.http.post<CategoriesListaInterface>(direccion, form);
  }


  getSingleCategory(id):Observable<CategoriesListaInterface>
  {
    let direccion = this.url + "api/categories/" + id;
    return this.http.get<CategoriesListaInterface>(direccion);
  }

  deleteCategory(id):Observable<CategoriesListaInterface>
  {
    let direccion = this.url + "api/categories/" + id;
    return this.http.delete<CategoriesListaInterface>(direccion);
  }

}
