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
        public static bool developerSignup(Developer developer)
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
                scmd.CommandText = "INSERT INTO developer_registraion(Owner_ID,Owner_Name,Website,Address,Contact_No,Builder_Name,Developer_Email)VALUES(@Owner_ID, @Owner_Name, @Website, @Address, @Contact_No, @Builder_Name,@Developer_Email)";
                scmd.Parameters.AddWithValue("Owner_ID", memberId);
                scmd.Parameters.AddWithValue("Owner_name", developer.OWNERNAME);
                scmd.Parameters.AddWithValue("Website", developer.WEBSITE);
                scmd.Parameters.AddWithValue("Builder_Name", developer.BUILDERNAME);
                scmd.Parameters.AddWithValue("Address", developer.ADDRESS);
                scmd.Parameters.AddWithValue("Developer_Email", developer.EMAIL);
                scmd.Parameters.AddWithValue("Contact_No", developer.PHNO);
                scmd.Connection = scon;
                scmd.Prepare();
                scmd.ExecuteNonQuery();
                scmd.Parameters.Clear();
                scmd.CommandText = "INSERT INTO login(uid,username, PASSWORD, usertype)VALUES(@uid,@username, @PASSWORD, @usertype)";

                scmd.Parameters.AddWithValue("uid", memberId);
                scmd.Parameters.AddWithValue("username", developer.EMAIL);
                scmd.Parameters.AddWithValue("PASSWORD", developer.PASSWORD);
                scmd.Parameters.AddWithValue("usertype", developer.USERTYPE);
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
                scmd.CommandText = "INSERT INTO membership(Membership_ID,Enrollment_Type,Organisation_Name,Pan_No,Chairman_MD,Mailing_Address,Company_Telephone_No,Fax,Mobile_No,Email,Website,Repre_Name,Repre_Desig,Repre_Mobile,Repre_Email)VALUES(@Membership_ID, @Enrollment_Type, @Organisation_Name, @Pan_No, @Chairman_MD, @Mailing_Address,@Company_Telephone_No, @Fax,@Mobile_No, @Email, @Website, @Repre_Name, @Repre_Desig, @Repre_Mobile, @Repre_Email)";

                scmd.Parameters.AddWithValue("Membership_ID", memberId);
                scmd.Parameters.AddWithValue("Enrollment_Type", member.category);
                scmd.Parameters.AddWithValue("Organisation_Name", member.organisation);
                scmd.Parameters.AddWithValue("Pan_No", member.pan);
                scmd.Parameters.AddWithValue("Chairman_MD", member.chairman);
                scmd.Parameters.AddWithValue("Mailing_Address", member.address);
                scmd.Parameters.AddWithValue("Company_Telephone_No", member.phno);
                scmd.Parameters.AddWithValue("Fax", member.fax);
                scmd.Parameters.AddWithValue("Mobile_No", member.mobile);
                scmd.Parameters.AddWithValue("Email", member.email);

                scmd.Parameters.AddWithValue("Website", member.website);
                scmd.Parameters.AddWithValue("Repre_Name", member.representative);
                scmd.Parameters.AddWithValue("Repre_Desig", member.designation);

                scmd.Parameters.AddWithValue("Repre_Mobile", member.rmobile);
                scmd.Parameters.AddWithValue("Repre_Email", member.remail);
                scmd.Prepare();
                scmd.ExecuteNonQuery();
                scmd.Parameters.Clear();
                scmd.CommandText = "INSERT INTO login(uid,username, PASSWORD, usertype)VALUES(@uid,@username, @PASSWORD, @usertype)";

                scmd.Parameters.AddWithValue("uid", memberId);
                scmd.Parameters.AddWithValue("username", member.email);
                scmd.Parameters.AddWithValue("PASSWORD", member.password);
                scmd.Parameters.AddWithValue("usertype", member.userType);
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

        public static bool SaveData(Dictionary<string, List<string>> myData)
        {
            bool res = false;
            MySqlConnection scon = new MySqlConnection(WebConfigurationManager.ConnectionStrings["MyLocalDb"].ConnectionString);
            MySqlCommand scmd = new MySqlCommand();
            scon.Open();
            scmd.Connection = scon;
            try
            {
                scmd.CommandText = "INSERT INTO completed_project (owner_id,project_name,location,project_type,no_of_unit)VALUES (@owner_id,@project_name,@location,@project_type,@no_of_unit)";
                scmd.Parameters.AddWithValue("owner_id", myData[""]);
                scmd.Parameters.AddWithValue("project_name", myData[""]);
                scmd.Parameters.AddWithValue("location", myData[""]);
                scmd.Parameters.AddWithValue("project_type", myData[""]);
                scmd.Parameters.AddWithValue("no_of_unit", myData[""]);
                scmd.Prepare();
                scmd.ExecuteNonQuery();
                scmd.Parameters.Clear();

                scmd.CommandText = "INSERT INTO photo_info(owner_id,proect_type,project_photo) VALUES (@owner_id,@proect_type,@project_photo)";
                scmd.Parameters.AddWithValue("owner_id", myData[""]);
                scmd.Parameters.AddWithValue("project_type", myData[""]);
                scmd.Parameters.AddWithValue("project_photo", myData[""]);
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

        public static string getLoginData(Login ldata)
        {
            string res = "error";
            MySqlConnection scon = new MySqlConnection(WebConfigurationManager.ConnectionStrings["MyLocalDb"].ConnectionString);
            MySqlCommand scmd = new MySqlCommand();
            scon.Open();
            scmd.Connection = scon;
            try
            {
                scmd.CommandText = "SELECT * FROM login WHERE username=@username AND password=@password AND usertype=@usertype";
                scmd.Parameters.AddWithValue("username", ldata.USERNAME);
                scmd.Parameters.AddWithValue("password", ldata.PASSWORD);
                scmd.Parameters.AddWithValue("usertype", ldata.USERTYPE);
                scmd.Prepare();
                res = scmd.ExecuteScalar().ToString(); 

            }
            catch (Exception ee)
            {
                res = "error";
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