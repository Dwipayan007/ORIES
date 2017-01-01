using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ores.Models;
using MySql.Data.MySqlClient;
using System.Web.Configuration;
using System.Data;

namespace Ores
{
    public class dbutility
    {
        public static bool memberSignup(Member member)
        {
            bool res = false;
            MySqlConnection scon = new MySqlConnection(WebConfigurationManager.ConnectionStrings["MyLocalDb"].ConnectionString);
            MySqlCommand scmd = new MySqlCommand();
            scon.Open();
            scmd.Connection = scon;
            try
            {
                Random r = new Random();
                int n = r.Next();
                string memberId = n.ToString();
                scmd.CommandText = "INSERT INTO owner_registraion(Owner_ID,Owner_Name,Website,Address,Contact_No,Builder_Name,Password)VALUES(@Owner_ID, @Owner_Name, @Website, @Address, @Contact_No, @Builder_Name,@Password)";
                scmd.Parameters.AddWithValue("Owner_ID", memberId);
                scmd.Parameters.AddWithValue("Owner_name", member.OWNERNAME);
                scmd.Parameters.AddWithValue("Website", member.WEBSITE);
                scmd.Parameters.AddWithValue("Builder_Name", member.BUILDERNAME);
                scmd.Parameters.AddWithValue("Address", member.ADDRESS);
                scmd.Parameters.AddWithValue("Contact_No", member.PHNO);
                scmd.Parameters.AddWithValue("Password", member.PASSWORD);
                scmd.Connection = scon;
                scmd.Prepare();
                scmd.ExecuteNonQuery();
                res = true;
            }
            catch (Exception ee)
            {
                res = false;
            }
            finally
            {
                if (scmd != null)
                    scmd.Dispose();
                if (scon.State == ConnectionState.Open)
                {
                    scon.Dispose();
                    scon.Close();
                }
            }
            return res;
        }
    }
}