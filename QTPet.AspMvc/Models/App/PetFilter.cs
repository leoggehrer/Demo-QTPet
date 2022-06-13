namespace QTPet.AspMvc.Models.App
{
    public partial class PetFilter
    {
        public bool HasValue => string.IsNullOrEmpty(Owner) == false || string.IsNullOrEmpty(Name) == false;
        public string? Owner { get; set; }
        public string? Name { get; set; }

        public override string ToString()
        {
            return $"Owner: {(string.IsNullOrEmpty(Owner) == false ? Owner : "---")} Name: {(string.IsNullOrEmpty(Name) == false ? Name : "---")}";
        }
    }
}
