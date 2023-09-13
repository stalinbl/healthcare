
namespace Healthcare.Domain
{
    public sealed class Patient : Audit
    {
        public string Name { get; set; }

        public override bool IsActive 
            => !DeletedIn.HasValue;

        public Patient(string name)
        {
            Name = name;
        }
    }
}