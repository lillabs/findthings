namespace Domain.Repositories.Implementations;

public class ThingRepository : ARepository<Thing>, IThingRepository
{
    public ThingRepository(ModelDbContext context) : base(context) { }
}