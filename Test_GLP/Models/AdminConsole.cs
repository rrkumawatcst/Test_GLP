using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using GLP.SqlDBClass;

namespace Test_GLP.Models
{
    public class AdminConsole
    {

    }
    
    public class Users
    {
        public String USER_ID { get; set; }
        public String USER_NAME { get; set; }
        public String USER_PASS { get; set; }
        public String CREATED_DATE{ get; set; }

        public List<Users> getUserList()
        {
            try
            {
                List<Users> lstUsers = new List<Users>();
                DataTable dt;
                dt = new SqlDBInstance().getDatatable(@"SELECT 
                                                        Usr_Id,Usr_Name,Usr_Pass,Created_Date 
                                                      FROM Tbl_GLP_Users");

                foreach(DataRow w in dt.Rows)
                {
                    lstUsers.Add(new Users() {
                        USER_ID = w[0].ToString(),
                        USER_NAME = w[1].ToString(),
                        USER_PASS = w[2].ToString(),
                        CREATED_DATE = w[3].ToString()
                    });
                }
                return lstUsers;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

    public class ViewUsers
    {
        public IEnumerable<Users> LstUsers{ get; set; }
    }
    
}
