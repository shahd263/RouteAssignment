namespace Demo.PL.Models.DepartmentViewModels
{
    public class DepartmentEditViewModel
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Code { get; set; } =string.Empty;
        public DateTime DateOfCreation { get; set; }

    }
}
