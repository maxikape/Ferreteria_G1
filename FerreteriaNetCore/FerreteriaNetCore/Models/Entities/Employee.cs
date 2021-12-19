namespace FerreteriaNetCore.Models.Entities
{
    public class EmployeeModel
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Surname { get; set; }

        public virtual string File { get; set; }

        public virtual string Category { get; set; }

        public virtual string DniNumber { get; set; }

        public virtual string DniType { get; set; }
        
    }
}