using System;
using MySql.Data.MySqlClient;

namespace PKMC2078Unit4
{
    class CRUD
    {
        static string connectionString = "SERVER=localhost;DATABASE=dotnetunit4;UID=root;PASSWORD=";

        /*static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- CRUD Operations Menu ---");
                Console.WriteLine("1. Create (Insert)");
                Console.WriteLine("2. Read (View All)");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateUser();
                        break;
                    case 2:
                        ReadUsers();
                        break;
                    case 3:
                        UpdateUser();
                        break;
                    case 4:
                        DeleteUser();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void CreateUser()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Name, Email, Age) VALUES (@Name, @Email, @Age)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);

                connection.Open();
                int rows = command.ExecuteNonQuery();
                Console.WriteLine(rows > 0 ? "User added successfully!" : "Error adding user.");
            }
        }

        static void ReadUsers()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users";
                MySqlCommand command = new MySqlCommand(query, connection);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("\n--- User List ---");
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["UserId"]}, Name: {reader["Name"]}, Email: {reader["Email"]}, Age: {reader["Age"]}");
                }
            }
        }

        static void UpdateUser()
        {
            Console.Write("Enter User ID to update: ");
            int userId = int.Parse(Console.ReadLine());

            Console.Write("Enter New Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter New Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter New Age: ");
            int age = int.Parse(Console.ReadLine());

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Name = @Name, Email = @Email, Age = @Age WHERE UserId = @UserId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);

                connection.Open();
                int rows = command.ExecuteNonQuery();
                Console.WriteLine(rows > 0 ? "User updated successfully!" : "Error updating user.");
            }
        }

        static void DeleteUser()
        {
            Console.Write("Enter User ID to delete: ");
            int userId = int.Parse(Console.ReadLine());

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM Users WHERE UserId = @UserId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                int rows = command.ExecuteNonQuery();
                Console.WriteLine(rows > 0 ? "User deleted successfully!" : "Error deleting user.");
            }
        }
    }*/
    }
}
