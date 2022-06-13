using Microsoft.AspNetCore.Mvc;
using QTPet.Logic.Contracts;
using QTPet.Logic.Entities.App;

namespace QTPet.AspMvc.Controllers.App
{
    public class PetsController : GenericController<Logic.Entities.App.Pet, Models.App.Pet>
    {
        public PetsController(IDataAccess<Pet> dataAccess) : base(dataAccess)
        {
        }

        private string FilterName => typeof(Models.App.PetFilter).Name;

        public override async Task<IActionResult> Index()
        {
            IActionResult? result;
            var filter = SessionWrapper.Get<Models.App.PetFilter>(FilterName) ?? new Models.App.PetFilter();

            if (filter.HasValue)
            {
                var instanceDataAccess = DataAccess as Logic.Controllers.App.PetsController;
                var accessModels = await instanceDataAccess!.QueryByAsync(filter.Owner, filter.Name);

                result = View(AfterQuery(accessModels).Select(e => ToViewModel(e, ActionMode.Index)));
            }
            else
            {
                var accessModels = await DataAccess.GetAllAsync();

                result = View(AfterQuery(accessModels).Select(e => ToViewModel(e, ActionMode.Index)));
            }

            ViewBag.Filter = filter;
            return result;
        }

        public async Task<IActionResult> Filter(Models.App.PetFilter filter)
        {
            IActionResult? result;

            if (filter.HasValue)
            {
                var instanceDataAccess = DataAccess as Logic.Controllers.App.PetsController;
                var accessModels = await instanceDataAccess!.QueryByAsync(filter.Owner, filter.Name);

                result = View("Index", AfterQuery(accessModels).Select(e => ToViewModel(e, ActionMode.Index)));
            }
            else
            {
                result = RedirectToAction("Index");
            }

            ViewBag.Filter = filter;
            SessionWrapper.Set<Models.App.PetFilter>(FilterName, filter);
            return result;
        }
    }
}
