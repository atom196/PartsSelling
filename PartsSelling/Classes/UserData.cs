using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsSelling.Classes
{
    internal class UserData
    {
        public static int UserId { get; set; }
        public static string LastName { get; set; }
        public static string FirstName { get; set; }
        public static string MiddleName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public static int RoleId { get; set; }

        public UserData(SqlDataReader reader)
        {
            UserId = reader.GetInt32(0);
            LastName = reader.GetString(1);
            FirstName = reader.GetString(2);
            MiddleName = reader.IsDBNull(3) ? null : reader.GetString(3);
            Email = reader.GetString(4);
            Phone = reader.GetString(5);
            RoleId = reader.GetInt32(8);
        }
    }
}
