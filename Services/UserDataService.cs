using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Services
{
    public class UserDataService : IUserDataService
    {
        private List<string> Elements;
        public UserDataService()
        {
            Elements = new List<string>();
            var rnd = new Random();
            Elements.Add($"value {rnd.Next()}");
            Elements.Add($"value {rnd.Next()}");
            Elements.Add($"value {rnd.Next()}");
            
        }
        public List<string> GetValues()
        {
            return Elements;
        }
    }
}
