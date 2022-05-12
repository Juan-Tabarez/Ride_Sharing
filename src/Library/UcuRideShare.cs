using System;
using System.Collections.Generic;

namespace PII_Herencia
{
    public class UcuRideShare
    {
        List<User> users = new List<User>();

        public void add(User user) 
        {
            users.Add(user);
        }

        public void  remove(User user)
        {
            users.Remove(user);
        }
    }
}