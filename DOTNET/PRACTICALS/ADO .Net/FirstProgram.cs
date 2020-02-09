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
            string totalStudentQuery = "select count(*) from `be_sem_6`";
            MySqlCommand cmd = new MySqlCommand(totalStudentQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine($"Total Students: {reader[0].ToString()}");
            }
            reader.Close();
            string passedStudentQuery = "SELECT COUNT(*) FROM `be_sem_6` where result='PASS'";
            cmd = new MySqlCommand(passedStudentQuery, con);
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine($"Passed Students: {reader[0].ToString()}");
            }
            reader.Close();
            string failedStudentQuery = "SELECT COUNT(*) FROM `be_sem_6` where result='FAIL'";
            cmd = new MySqlCommand(failedStudentQuery, con);
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine($"Failed Students: {reader[0].ToString()}");
            }
        } 
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
