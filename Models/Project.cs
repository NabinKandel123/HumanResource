namespace HumanResources.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
