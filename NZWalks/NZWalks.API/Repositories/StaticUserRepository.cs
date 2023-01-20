using NZWalks.API.Models.Domains;

namespace NZWalks.API.Repositories
{
    public class StaticUserRepository : IUserRepository
    {
        private List<User> users = new List<User>()
        {
            new User()
            {
                 FirstName="Read Only", LastName="User", EmailAddress="Readonly@user.com", Id=new Guid(),
                 Username="Readonly@user.com", Password="Readonly@user",
                 Roles= new List<string> {"reader"}
            },
            new User()
            {
                 FirstName="Read Write", LastName="User", EmailAddress="Readwrite@user.com", Id=new Guid(),
                 Username="Readwrite@user.com", Password="Readwrite@user",
                 Roles= new List<string> {"reader","writer"}
            }
        };

        public async Task<User> AuthenticateAsync(string username, string password)
        {
            var user = users.Find(x => x.Username.Equals(username, StringComparison.InvariantCultureIgnoreCase) && x.Password == password);
            return user;
        }
    }
}
