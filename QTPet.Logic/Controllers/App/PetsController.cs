using QTPet.Logic.Entities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTPet.Logic.Controllers.App
{
    public sealed class PetsController : GenericController<Entities.App.Pet>
    {
        public PetsController()
        {
        }

        public PetsController(ControllerObject other) : base(other)
        {
        }

        protected override void ValidateEntity(ActionType actionType, Pet entity)
        {
            base.ValidateEntity(actionType, entity);
        }

        public async Task<Entities.App.Pet[]> QueryByAsync(string? owner, string? name)
        {
            var query = EntitySet.AsQueryable();

            if (string.IsNullOrEmpty(owner) == false)
            {
                query = query.Where(e => e.Owner != null && e.Owner.Contains(owner));
            }
            if (string.IsNullOrEmpty(name) == false)
            {
                query = query.Where(e => e.Name.Contains(name));
            }
            return await query.AsNoTracking().ToArrayAsync();
        }
    }
}
