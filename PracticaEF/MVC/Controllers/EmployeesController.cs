using MVC.Models;
using PracticaBF.Entities;
using PracticasBF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class EmployeesController : Controller
    {
        EmployeesLogic logic = new EmployeesLogic();
       
        // GET: Employees

        public ActionResult Index()
        {
            List<Employees> employees = logic.GetAll();

            List<EmployeesView> employeesViews = employees.Select(e => new EmployeesView
            {
                Id = e.EmployeeID,
                Nombre = e.FirstName,
                Apellido = e.LastName,
                Puesto = e.Title,
            }).ToList();
            
            return View(employeesViews);
        }

        public ActionResult Insert()
        {
            ViewBag.Message = "Insert";

            return View();
        }

        [HttpPost]
        public ActionResult Insert(EmployeesView employeesView)
        {
            try
            {
                Employees employeesEntity = new Employees
                {
                    FirstName = employeesView.Nombre,
                    LastName = employeesView.Apellido,
                    Title = employeesView.Puesto
                };

                logic.add(employeesEntity);

                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return RedirectToAction("Index", "Error");
            }
        
        }   

        public ActionResult Update(int id)
        {
            Employees employeesUpdate = logic.GetOne(id);
            EmployeesView employeesView = new EmployeesView
            {
                Id = employeesUpdate.EmployeeID,
                Nombre = employeesUpdate.FirstName,
                Apellido = employeesUpdate.LastName,
                Puesto = employeesUpdate.Title
            };

            ViewBag.Message = "Update";

            return View("Insert", employeesView);
        }
        [HttpPost]
        public ActionResult Update(EmployeesView employeesView)
        {
            try
            {
                Employees employeesEntity = new Employees
                {
                    EmployeeID = employeesView.Id,
                    Title = employeesView.Puesto,
                };

                logic.Update(employeesEntity);

            }
            catch (NullReferenceException)
            {
                return RedirectToAction("Index", "Error");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
            
            return RedirectToAction("Index");

        }


        public ActionResult delete(int id)
        {
            try
            {
                logic.Delete(id);

                return RedirectToAction("index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
           
        }
    }
}