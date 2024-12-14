using System;


public class AgeNotValidException : Exception
{
  
    public AgeNotValidException(string message) : base(message)
    {
    }

    public AgeNotValidException(string message, Exception inner) : base(message, inner)
    {
    }
}

namespace Bhumika.Unit_3
{
    class customException
    {
        /*static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age:");
                int age = int.Parse(Console.ReadLine());

                if (age < 0 || age > 150)
                {
                    throw new AgeNotValidException("Age must be between 0 and 150.");
                }

                Console.WriteLine($"Your age is {age}.");
            }
            catch (AgeNotValidException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format Error: Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }

            Console.ReadKey();
        }*/
    }
}
