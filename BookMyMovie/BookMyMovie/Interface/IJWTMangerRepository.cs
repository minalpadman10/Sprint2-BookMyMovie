using BookMyMovie.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyMovie.Interface
{
    public interface IJWTMangerRepository
    {
        Tokens Authenicate(loginViewModels users, bool IsRegister);
    }
}
