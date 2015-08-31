using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using FindYourCar.Models;
using System.Data;
//using System.Data.IDataReader;

namespace FindYourCar.DAO_Models
{
    public class CarDAO
    {
        public static SqlConnection conn = null;
        public static SqlConnection conn1 = null;
        public static SqlConnection conn2 = null;
        public static SqlCommand cmd = new SqlCommand();
        public static SqlCommand cmd1 = new SqlCommand();
        public static SqlCommand cmd2 = new SqlCommand();
        public static string sqlconn = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        public static string sqlconn1;
        public static string sqlconn2;
        //public static CarModel model1 =new CarModel();

        List<CarModel> model1 = new List<CarModel>();

        public static void InsertCar(CarModel model)
        {


            SqlConnection conn = new SqlConnection(sqlconn);
            conn.Open();

            try
            {
                String num = "Select (max(id))+1 from Car";

                int x = Int32.Parse(num);

                string query = "Insert into Car(id,make,variant,type,engine_type,color,price,mileage,capacity,numofowners,condition_car,status,transmission,fuel,additionalinfo) values ('" + x + "','" + model.Make + "','" + model.Variant + "','" + model.Type + "','" + model.EngineType + "','" + model.Color + "','" + model.Price + "','" + model.Mileage + "','" + model.Capacity + "','" + model.NumberOfOwners + "','" + model.Condition + "','" + model.Status + "','" + model.Transmission + "','" + model.Fuel + "','" + model.AdditionalInfo + "')";

                cmd = new SqlCommand(query, conn);
                cmd.ExecuteReader();
                conn.Close();
            }

            catch (Exception e)
            {

            }


        }
        public static List<Models.ViewModel.CarViewModel> GetCar(Models.ViewModel.SearchViewModel model1)
        {
         //   List<String> list = new List<String>();

            //sqlconn1 = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();



           // using (SqlConnection con1 = new SqlConnection(sqlconn))
            //{
              //  con1.Open();

                // Set up a command with the given query and associate
                // this with the current connection.

                //SqlCommand cmd = new SqlCommand();
                //string query = null;
                //query = "SELECT * from Car WHERE make='" + model1.Make + "'";
                //cmd.CommandText = query;
                //cmd.Connection = con1;


                //using (IDataReader dr = cmd.ExecuteReader())
                //{
                  //  while (dr.Read())
                    //{
                      //  list.Add(dr[0].ToString());
                    //}
                //}
            //}


            //return list;

            List<Models.ViewModel.CarViewModel> model2 = new List<Models.ViewModel.CarViewModel>();

            Models.ViewModel.CarViewModel model = new Models.ViewModel.CarViewModel();

            string query = "Select * from Car where make='" + model1.Make + "'";

            cmd1 = new SqlCommand(query, conn1);
           

            //cmd1 = new SqlCommand("SELECT * FROM Car WHERE make=Model1.Make or price between Model1.Price or ", conn1);

            //SqlDataReader reader = cmd1.ExecuteReader();

            SqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {

                // model = reader.GetString();
                model.Make = reader.GetString(1);
                model.Variant = reader.GetString(2);
                model.Type = reader.GetString(3);
                model.EngineType = reader.GetString(4);
                model.Color = reader.GetString(5);
                model.Price = Convert.ToInt16(reader.GetString(6));
                model.Mileage = Convert.ToInt16(reader.GetString(7));
                model.Capacity = reader.GetString(8);
                model.NumberOfOwners = Convert.ToInt16(reader.GetString(9));
                model.Condition = reader.GetString(10);
                model.Status = reader.GetString(11);
                model.Transmission = reader.GetString(12);
                model.Fuel = reader.GetString(13);
                model.AdditionalInfo = reader.GetString(14);


                // }
                // model1 = model;
                // reader.Close();
                // conn1.Close();
                model2.Add(model);     

            }
            return model2;

        }
    }
}

