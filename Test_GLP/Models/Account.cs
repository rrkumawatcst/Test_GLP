using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using GLP.SqlDBClass;

namespace Test_GLP.Models
{
    public class Account
    {
        public String USER_NAME { get; set; }
        public String USER_PASS { get; set; }

        Hashtable ht;


        public int createAccount(Account a)
        {
            try
            {
                ht = new Hashtable();
                ht["USR_ID"] = -1;
                ht["Usr_Name"] = a.USER_NAME;
                ht["Usr_Pass"] = a.USER_PASS;
                return new SqlDBInstance().generateCommand("Proc_GLP_USER_InsertData", ht);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}