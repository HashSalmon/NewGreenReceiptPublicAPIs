using GreenReceiptWebApi.BLL.Contracts;
using GreenReceiptWebApi.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GreenReceiptWebApi.Web.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserServices userServices;

        public User Get()
        {
            return new User() { UserId = 1, Email = "test", FirstName = "f", LastName = "l", Password = "123", Username = "user" };
        }


    }
}
