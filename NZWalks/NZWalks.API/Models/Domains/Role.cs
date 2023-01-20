namespace NZWalks.API.Models.Domains
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        // Navigation property
        public List<User_Role> UserRoles { get; set; }
    }
}
