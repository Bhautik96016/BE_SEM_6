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

            string query = "SELECT count(*) 'students' FROM `be_sem_6`";
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Console.WriteLine($"Total Students: {ds.Tables[0].Rows[0]["students"]}");
            
            ds.Clear();
            da = new MySqlDataAdapter("SELECT count(*) 'students' FROM `be_sem_6` where `result`='PASS'", con);
            da.Fill(ds);
            Console.WriteLine($"Passed Students: {ds.Tables[0].Rows[0]["students"]}");

            ds.Clear();
            da = new MySqlDataAdapter("SELECT count(*) 'students' FROM `be_sem_6` where `result`='FAIL'", con);
            da.Fill(ds);
            Console.WriteLine($"Failed Students: {ds.Tables[0].Rows[0]["students"]}");
        } 
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
