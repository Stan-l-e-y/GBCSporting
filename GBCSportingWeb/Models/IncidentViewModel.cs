namespace GBCSportingWeb.Models
{
    public class IncidentViewModel
    {
        public Incident Incident { get; set; }

        public string Operation { get; set; } = "";

        public string IncidentFilter { get; set; } = "all";
    }
}
