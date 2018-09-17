using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ThreeT
{
    class Logic
    {
        

        public static void CreateTable()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CKSQ4K0\TESTSERVER;Initial Catalog=TestDb;Integrated Security=True");
            try
            {
                //Logic obj = new Logic();
                //con = new SqlConnection();

                SqlCommand cmd = new SqlCommand("create table Student_Suyog1(id varchar(100),name varchar(100),email varchar(50))",con);

                con.Open();

                cmd.ExecuteNonQuery();

                
            }
            catch (Exception e)
            {
                //Console.WriteLine("Something Went Wrong" + e.Message);
            }

            finally
            {
                con.Close();
            }
        }

        public static void InsertRecord(Format obj)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CKSQ4K0\TESTSERVER;Initial Catalog=TestDb;Integrated Security=True");

            try
            {

               // con = new SqlConnection();

                con.Open();

                SqlCommand cmd = new SqlCommand("insert into Student_Suyog1 values('"+obj.id+"','"+obj.name+"','"+obj.email+"')", con);



                cmd.ExecuteNonQuery();

               
            }
            catch (Exception e)
            {
                //Console.WriteLine("Something Went Wrong" + e.Message);
            }

            finally
            {
                con.Close();
            }
        }
        


    }
}
