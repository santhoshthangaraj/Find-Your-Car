using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;



using FindYourCar.Models;

namespace FindYourCar.DAO_Models
{
    public static class AccountDAO
    {

       
        public static SqlConnection conn=null;
        public static SqlCommand cmd = new SqlCommand();
        public static string sqlconn;

          public static SqlConnection conn1=null;
        public static SqlCommand cmd1 = new SqlCommand();
        public static string sqlconn1;

        public static void InsertAccount(AccountModel model)
        {
            
         sqlconn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlConnection  conn = new SqlConnection(sqlconn);
            conn.Open();

            try
            {
                
               
                string query = "Insert into Account(email,password,first_name,last_name,middle_initial,dateofbirth,phone_number,address_line1,address_line2,zipcode,start_date) values ('" + model.Email +"','" + model.Password + "','" + model.FirstName + "','" + model.LastName + "','" + model.MiddleInitial + "','" + model.DateOfBirth + "','" + model.PhoneNumber + "','" + model.AddressLine1 + "','" + model.AddressLine2 + "','" + model.ZipCode + "','" + model.StartTime+ "')"; 

                cmd = new SqlCommand(query, conn);
                cmd.ExecuteReader();
                conn.Close();
            }
         catch(Exception e)
            {

            }        

        }
        public static String Verify(Models.ViewModel.LoginViewModel model)
        {

            sqlconn1 = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlConnection conn1 = new SqlConnection(sqlconn1);
            conn1.Open();

            string query1 = "Select password from Account where email_id='" + model.Email + "'";

            cmd1 = new SqlCommand(query1, conn1);
            SqlDataReader reader = cmd1.ExecuteReader();
            String password = reader[1].ToString();

           // if (reader.Read())
            //{
              //   String password = reader[0].ToString();
                
            //}
            
            conn1.Close();
            return password;
        }
        }
        
}