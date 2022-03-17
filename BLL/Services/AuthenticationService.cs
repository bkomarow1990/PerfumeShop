using BLL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<IdentityUser> _user;
        private readonly SignInManager<IdentityUser> _signInManager;

        public async Task RegisterAsync()
        {
            await _signInManager.SignOutAsync();
        }
        public AuthenticationService(UserManager<IdentityUser> user, SignInManager<IdentityUser> signInManager)
        {
            _user = user;
            _signInManager = signInManager;
        }
    }
}
