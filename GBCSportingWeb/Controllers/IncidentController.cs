using GBCSportingWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace GBCSportingWeb.Controllers
{
    public class IncidentController : Controller
    {

        private ApplicationDbContext context { get; set; }

        public IncidentController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(string filter = "all")
        {
            var data = new IncidentListViewModel
            {
                IncidentFilter = filter,
                Incidents = context.Incidents.ToList(),
                Products = context.Products.ToList(),
                Technicians = context.Technicians.ToList(),
                Customers = context.Customers.ToList(),
            };

            IQueryable<Incident> query = context.Incidents;
            if(filter == "open")
            {
                query = query.Where(
                    i => i.DateClosed == null);
                data.IncidentFilter = "open";
            }
            if (filter == "unassigned")
            {
                query = query.Where(
                    i => i.Technician.TechnicianId == null);
                data.IncidentFilter = "unassigned";
            }

            data.Incidents = query.ToList();

            HttpContext.Session.SetString("Active", "Incidents");

            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {

            var data = new IncidentListViewModel
            {
                Products = context.Products.ToList(),
                Technicians = context.Technicians.ToList(),
                Customers = context.Customers.ToList(),
                Incident = new Incident(),
                Operation = "add"
            };

            return View("Edit", data);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = new IncidentListViewModel
            {
                Products = context.Products.ToList(),
                Technicians = context.Technicians.ToList(),
                Customers = context.Customers.ToList(),
                Incident = context.Incidents.Find(id),
                Operation = "edit"
            };

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(IncidentListViewModel incidentListView)
        {
            if (ModelState.IsValid)
            {
                if(incidentListView.Incident.IncidentId == 0)
                {
                    if(incidentListView.Incident.DateOpened == null)
                    {
                        incidentListView.Incident.DateOpened = DateTime.Now;
                    }

                    context.Incidents.Add(incidentListView.Incident);
                    context.SaveChanges();
                }
                else
                {
                    context.Incidents.Update(incidentListView.Incident);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            else
            {
                var data = new IncidentListViewModel
                {
                    Products = context.Products.ToList(),
                    Technicians = context.Technicians.ToList(),
                    Customers = context.Customers.ToList(),
                    Incident = context.Incidents.Find(incidentListView.Incident.IncidentId),
                    Operation = (incidentListView.Incident.IncidentId == 0) ? "Add" : "Edit"
                };

                return View(data);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var incident = context.Incidents.Find(id);
            context.Incidents.Remove(incident);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
