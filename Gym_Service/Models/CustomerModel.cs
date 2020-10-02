using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gym_Service.Models
{
    public class CustomerModel
    {
        int customerID;
        string customerName;
        string customerSurname;
        string customerCellNumber;
        string customerEmail;
        DateTime joinDate;

        public CustomerModel(int id, string name, string surname, string cell, string email, DateTime join)
        {
            customerID = id;
            customerName = name;
            customerSurname = surname;
            customerCellNumber = cell;
            customerEmail = email;
            joinDate = join;

        }

    }
}