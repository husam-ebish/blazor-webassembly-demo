using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace ConfTool.Server
{
    public class EmptyAuthenticationStateProvider : AuthenticationStateProvider
    {
        public EmptyAuthenticationStateProvider()
        {
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var cp = new ClaimsPrincipal();
            var aus = new AuthenticationState(cp);

            return Task.FromResult(aus);
        }
    }
}
