namespace GBCSportingWeb.Models
{
    public class IncidentListViewModel : IncidentViewModel
    {
        public List<Incident>? Incidents { get; set; }

        private List<Technician>? technicians;

        public List<Technician>? Technicians
        {
            get => technicians;
            set
            {
                technicians = value;
                technicians.Insert(0, new Technician { TechnicianId = 1});
            }
        }

        private List<Customer>? customers;

        public List<Customer>? Customers
        {
            get => customers;
            set
            {
                customers = value;
                customers.Insert(0, new Customer {});
            }
        }

        private List<Product>? products;

        public List<Product>? Products
        {
            get => products;
            set
            {
                products = value;
                products.Insert(0, new Product {});
            }
        }

        //The next methods will help determine what to display in our view
        public void checkOperation(string op)
        {
            if(op == "add")
            {
                Operation = "add";
            }
            else
            {
                Operation = "edit";
            }
        }


    }
}
