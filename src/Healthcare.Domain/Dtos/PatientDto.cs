using Healthcare.Domain.Enuns;

namespace Healthcare.Domain.Dtos
{
    public sealed class PatientDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public EGender Gender  { get; set; }
    }
}