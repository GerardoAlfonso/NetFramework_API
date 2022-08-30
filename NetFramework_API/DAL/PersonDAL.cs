using NetFramework_API.DAL.DB;
using NetFramework_API.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NetFramework_API.DAL
{
    public class PersonDAL : CRUD<Person>
    {
        private DB_Connection objConnection;
        private SqlCommand sqlCommand;
        public PersonDAL()
        {
            objConnection = DB_Connection.CreateConnection();
        }

        public void create(Person entity)
        {
            throw new NotImplementedException();
        }

        public void delete(Person entity)
        {
            throw new NotImplementedException();
        }

        public List<Person> getAll()
        {
            List<Person> personas = new List<Person>();
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString()))
                {
                    con.Open();

                    string query = "SELECT * FROM Person";
                    
                    sqlCommand = new SqlCommand(query, con);

                    //also
                    // var query = new SqlCommand("SELECT * FROM Persona", con);


                    // dr is a DataReader object
                    // ExecuteReader for read information
                    using(var dr = sqlCommand.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Person objPersona = new Person
                            {
                                IdPerson = Convert.ToInt32(dr["IdPerson"]),
                                Name = dr["Name"].ToString(),
                                LastName = dr["LastName"].ToString(),
                                Email = dr["Email"].ToString(),
                            };

                            // add obj to List<>
                            personas.Add(objPersona);
                        }
                    }


                }

            }catch(Exception ex)
            {
                throw;
            }
            return personas;
        }

        public Person getById(long Id)
        {
            throw new NotImplementedException();
        }

        public void update(Person DBEntity, Person entity)
        {
            throw new NotImplementedException();
        }
    }
}