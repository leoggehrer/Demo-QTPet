using QTPet.Logic.Entities;

namespace QTPet.Logic.DataContext
{
    /// <summary>
    /// This part is for the domain specific extensions
    /// </summary>
    partial class ProjectDbContext
    {
        public DbSet<Entities.App.Pet>? PetSet { get; set; }

        partial void GetDbSet<E>(ref DbSet<E>? dbSet, ref bool handled) where E : IdentityEntity
        {
            if (typeof(E) == typeof(Entities.App.Pet))
            {
                handled = true;
                dbSet = PetSet as DbSet<E>;
            }
        }
    }
}
    
