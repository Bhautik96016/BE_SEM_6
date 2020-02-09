using System;
using MySql.Data.MySqlClient;

public class ConnectedAccessFirst
{
    public static void Main(string[] args)
    {
        try
        {
            string cs = "server=localhost;user id=root;database=university";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            Console.Write("Enter Enrollment Number: ");
            string enrollmentNumber = (Console.ReadLine()).Trim();
            if (enrollmentNumber.Length > 0)
            {
                string query = "SELECT * FROM `be_sem_6` WHERE `enrollmentNumber`=" + enrollmentNumber;
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("\n\n||||||||||||||||||||||||||||||||||||||||||||||||");
                while (reader.Read()) { 

                    Console.Write($"Name: {reader[0]}" +
                        $"\nEnrollment Number: {reader[7]}" +
                        $"\n=============================" +
                        $"\nResult \t .NET Technologies: {reader[1]} \t Advance Java: {reader[2]} \t Software Engineering: {reader[3]} \t Web Technologies: {reader[4]} \t TOC: {reader[5]} \t DE: {reader[6]}" +
                        "\n=============================\n");



                    if (reader[8].ToString() == "PASS")
                    {
                        Console.WriteLine("Congratulations, You are passed!!");
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately, You are failed!!");
                    }
                    Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||");
                }
            }
            else
                Console.WriteLine("\n Invalid Enrollment Number!!");
        } 
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
