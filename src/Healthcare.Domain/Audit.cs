
namespace Healthcare.Domain
{
    public abstract class Audit : Entity
    {
        public DateTimeOffset CreatedIn { get; init; }
        public DateTimeOffset? UpdatedIn { get; private set; }
        public DateTimeOffset? DeletedIn { get; private set; }
        
        public bool IsActive 
            => !DeletedIn.HasValue;

        public Audit()
        {
            CreatedIn = DateTimeOffset.UtcNow;
        }

        public virtual void MarkAsDeleted()
            => DeletedIn ??= DateTimeOffset.UtcNow; 
    }
}