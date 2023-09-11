
namespace Healthcare.Domain
{
    public sealed class Patient : Audit
    {
        public string Name { get; set; }
        
        public Patient(string name)
        {
            Name = name;
        }
    }
}