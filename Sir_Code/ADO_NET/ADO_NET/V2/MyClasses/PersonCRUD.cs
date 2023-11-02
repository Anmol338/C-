using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.V2.MyClasses {
    internal class PersonCRUD:MyDatabase {
        public bool Insert(Person person) {
            string sql = "INSERT INTO persond(pid, full_name, contact_address) values(@pid, @full_name, @contact_address);";
            bool result = false;
            try {
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
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
                result = false;
            }
            return result;
        }
    }
}
