using System;
using MySql.Data.MySqlClient;
using System.Data;
public class DisconnectedAccess
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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `be_sem_6` where `enrollmentNumber`=" + enrollmentNumber, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Console.WriteLine("\n\n||||||||||||||||||||||||||||||||||||||||||||||||");
                Console.Write($"Name: {ds.Tables[0].Rows[0]["name"]}" +
                        $"\nEnrollment Number: {ds.Tables[0].Rows[0]["enrollmentNumber"]}" +
                        $"\n=============================" +
                        $"\nResult \t .NET Technologies: {ds.Tables[0].Rows[0]["DOTNET"]} \t Advance Java: {ds.Tables[0].Rows[0]["AJAVA"]} \t Software Engineering: {ds.Tables[0].Rows[0]["SE"]} \t Web Technologies: {ds.Tables[0].Rows[0]["WT"]} \t TOC: {ds.Tables[0].Rows[0]["TOC"]} \t DE: {ds.Tables[0].Rows[0]["DE"]}" +
                        "\n=============================\n");

                if (ds.Tables[0].Rows[0]["RESULT"].ToString() == "PASS")
                {
                    Console.WriteLine("Congratulations, You are passed!!");
                }
                else
                {
                    Console.WriteLine("Unfortunately, You are failed!!");
                }
                Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||");

            }
            else
                Console.WriteLine("Enter valid enrollment number!!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
