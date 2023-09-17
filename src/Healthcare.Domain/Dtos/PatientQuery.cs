namespace Healthcare.Domain.Dtos
{
    public sealed class PatientQuery
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTimeOffset CreatedIn { get; set; }
    }
}