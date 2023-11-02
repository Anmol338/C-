using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.V2.MyClasses
{
    internal class CRUDV2 : MyDatabase
    {
        public bool InsertPerson(Person person)
        {
            string sql = "INSERT INTO persond(pid, full_name, contact_address) values(@pid, @full_name, @contact_address);";
            bool result = false;
            try
            {
                MySqlConnection conn = Connect();
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlParameter[] sqlparams = new MySqlParameter[3];
                sqlparams[0] = new MySqlParameter("@pid", person.PID);
                sqlparams[1] = new MySqlParameter("@full_name", person.FullName);
                sqlparams[2] = new MySqlParameter("@contact_address", person.ContactAddress);
                command.Parameters.Add(sqlparams[0]);
                command.Parameters.Add(sqlparams[1]);
                command.Parameters.Add(sqlparams[2]);
                object res = command.ExecuteNonQuery();
                Close(conn);
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                result = false;
            }
            return result;
        }

        public bool UpdatePerson(Person person) {
            string sql = "UPDATE persond SET full_name=@full_name, contact_address=@contact_address WHERE pid=@pid;";
            bool result = false;
            try {
                MySqlConnection conn = Connect();
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlParameter[] sqlparams = new MySqlParameter[3];                
                sqlparams[0] = new MySqlParameter("@full_name", person.FullName);
                sqlparams[1] = new MySqlParameter("@contact_address", person.ContactAddress);
                sqlparams[2] = new MySqlParameter("@pid", person.PID);
                command.Parameters.Add(sqlparams[0]);
                command.Parameters.Add(sqlparams[1]);
                command.Parameters.Add(sqlparams[2]);
                object res = command.ExecuteNonQuery();
                Close(conn);
                result = true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
                result = false;
            }
            return result;
        }

        public bool DeletePerson(Person person) {
            string sql = "DELETE FROM persond WHERE pid=@pid;";
            bool result = false;
            try {
                MySqlConnection conn = Connect();
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlParameter[] sqlparams = new MySqlParameter[1];                
                sqlparams[0] = new MySqlParameter("@pid", person.PID);
                command.Parameters.Add(sqlparams[0]);                
                object res = command.ExecuteNonQuery();
                Close(conn);
                result = true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
                result = false;
            }
            return result;
        }

        public ArrayList AllPersons() {
            ArrayList persons = new ArrayList();
            try {
                string sql = "SELECT * FROM persond";
                MySqlConnection conn = Connect();
                MySqlCommand command = new MySqlCommand(sql, conn);                
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    Person person = new Person();
                    person.PID = reader.GetInt32("pid");
                    person.FullName = reader.GetString("full_name");
                    person.ContactAddress = reader.GetString("contact_address");
                    persons.Add(person);
                }
                Close(conn);
            }
            catch (Exception ex) {
                Console.WriteLine("Error : " + ex.Message);
            }
            return persons;
        }

        public Person SearchPerson(Person person)
        {
            try
            {
                string sql = "SELECT * FROM persond WHERE pid=@pid";
                MySqlConnection conn = Connect();
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlParameter[] sqlparams = new MySqlParameter[1];
                sqlparams[0] = new MySqlParameter("@pid", person.PID);
                command.Parameters.Add(sqlparams[0]);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    person = new Person();
                    person.PID = reader.GetInt32("pid");
                    person.FullName = reader.GetString("full_name");
                    person.ContactAddress = reader.GetString("contact_address");
                }
                Close(conn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            return person;
        }
    }
}
