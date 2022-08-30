using NetFramework_API.DAL;
using NetFramework_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFramework_API.BL
{
    public class PersonBL
    {
        private PersonDAL personDAL = new PersonDAL();

        public List<Person> ListPerson()
        {
            return personDAL.getAll();
        }
    }
}