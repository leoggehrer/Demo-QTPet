namespace QTPet.AspMvc.Models.App
{
    public class Pet : IdentityModel
    {
        [MaxLength(256)]
        public string? Owner { get; set; }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
    }
}
