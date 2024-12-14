using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PKMC2078Unit4
{
    internal class DatabaseDemo
    {
        public void AddStudent()
        {
            try
            {
                string name = Console.ReadLine(); 
                int roll = int.Parse(Console.ReadLine());
                int semester = int.Parse(Console.ReadLine());
               
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=dotnetunit4;UID=root;PASSWORD=");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into students(name,roll,semester) values(@n,@r,@s)", conn);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@r", roll);
                cmd.Parameters.AddWithValue("@s", semester);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    Console.WriteLine("Insert success");
                }
                else
                {
                    Console.WriteLine("Insert failed");
                }
                conn.Close();
            }
            catch (MySqlException mex)
            {
                Console.WriteLine("Database error: " + mex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void ListStudent()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=dotnetunit4;UID=root;PASSWORD=");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from students", conn);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                mda.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    Console.WriteLine("Id: \t\tName \t\t\t Roll \t\t Semester");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string id = dt.Rows[i]["Id"].ToString();
                        string name = dt.Rows[i]["name"].ToString();
                        string roll = dt.Rows[i]["roll"].ToString();
                        string semester = dt.Rows[i]["semester"].ToString();
                        Console.WriteLine($" {id}\t\t {name} \t  {roll} \t\t {semester}");

                    }
                }
                else
                {
                    Console.WriteLine("Data not found");
                }
                conn.Close();
            }
            catch (MySqlException mex)
            {
                Console.WriteLine("Database error: " + mex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        /*static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Select Option : \n 1. Insert \t 2. Select");
            option = int.Parse(Console.ReadLine());
            DatabaseDemo demo = new DatabaseDemo();
            switch (option)
            {
                case 1:
                    demo.AddStudent();
                    break;
                case 2:
                    demo.ListStudent();
                    break;
            }
            Console.ReadKey();
        }*/
    }
}