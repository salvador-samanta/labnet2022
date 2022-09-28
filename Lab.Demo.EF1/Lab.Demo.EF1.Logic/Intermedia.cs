using Lab.Demo.EF1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF1.Logic
{
    public class Intermedia : CategoriesLogic
    {
        CategoriesLogic categoriesLogic = new CategoriesLogic();
        public void categoriesList()
        {
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            List<Categories> listado = categoriesLogic.GetAll();

            foreach (Categories categories in categoriesLogic.GetAll())
            {
                Console.WriteLine($"{categories.CategoryID} - {categories.CategoryName} - {categories.Description}");
                
            }
        }

        public void addCategories(int idIngresada, string nombreIngresado, string descripcionIngresada)
        {
            categoriesLogic.add(new Categories
            {
                CategoryID = idIngresada,
                CategoryName = nombreIngresado,
                Description = descripcionIngresada,
            });
        }

        public void deleteCategories(int id)
        {
            categoriesLogic.Delete(id);

        }

        public void updateCategories(int id, string nombre, string descripcion)
        {
            categoriesLogic.Update(new Categories
            {
                CategoryID = id,
                CategoryName = nombre,
                Description = descripcion,

            });

        }



        public class SuppliersIntermedia : SuppliersLogic
        {
            SuppliersLogic suppliersLogic = new SuppliersLogic();
            public void suppliersList()
            {
                
                List<Suppliers> listado = suppliersLogic.GetAll();

                foreach (var Item in suppliersLogic.GetAll())
                {
                    Console.WriteLine($"{Item.SupplierID} -" +
                                      $"{Item.CompanyName} -" +
                                      $"{Item.ContactName} -" +
                                      $"{Item.ContactTitle}" +
                                      $"{Item.Address}" +
                                      $"{Item.City}" +
                                      $"{Item.Region}" +
                                      $"{Item.PostalCode}" +
                                      $"{Item.Country}" +
                                      $"{Item.Phone}" +
                                      $"{Item.Fax}" +
                                      $"{Item.HomePage}");
                }
            }

            public void Add(Suppliers newSupplier)
            {
                context.Suppliers.Add(newSupplier);
                context.SaveChanges();

               
            }
            public void addSuppliers(int idSIngresada, string compañiaIngresada, string direccionIngresada)
            {
                suppliersLogic.add(new Suppliers
                {
                    SupplierID = idSIngresada,
                    CompanyName = compañiaIngresada,
                    ContactName = direccionIngresada
                                        
                });
            }

            public void deleteSupplies(int id)
            {
                suppliersLogic.Delete(id);

            }

        }
    }
}

