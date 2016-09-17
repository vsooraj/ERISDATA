using System.Security.Principal;
using ErisData.Entities;

namespace ErisData.Services
{
    public class MembershipContext
    {
        public IPrincipal Principal { get; set; }
        public User User { get; set; }
        public bool IsValid()
        {
            return Principal != null;
        }
    }
}
