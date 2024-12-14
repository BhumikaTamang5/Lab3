using System;
using MySql.Data.MySqlClient;

class Tourism
{
    static string connectionString = "SERVER=localhost;DATABASE=dotnetunit4;UID=root;PASSWORD=";

    static void Main(string[] args)
    {
        Console.WriteLine("--- Tourism Information ---");
        Console.Write("Enter Destination Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Destination Description: ");
        string description = Console.ReadLine();

        Console.Write("Enter Duration (in days): ");
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.Write("Invalid input. Enter Duration (in days): ");
        }

        DateTime createdDate = DateTime.Now;

        SaveTourDestination(title, description, duration, createdDate);
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void SaveTourDestination(string title, string description, int duration, DateTime createdDate)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            string query = "INSERT INTO TourDestination (Title, Description, Duration, CreatedDate) VALUES (@Title, @Description, @Duration, @CreatedDate)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@Duration", duration);
            command.Parameters.AddWithValue("@CreatedDate", createdDate);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Tour destination information saved successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to save tour destination information.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
