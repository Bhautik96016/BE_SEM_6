using System;
using MySql.Data.MySqlClient;
using System.Data;

public class ConnectedAccessFirst
{
    public static void Main(string[] args)
    {
        try
        {
            string cs = "server=localhost;user id=root;database=university";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            bool isRunning = true;
            while(isRunning)
            {
                Console.WriteLine("1. Insert Result");
                Console.WriteLine("2. Update Result");
                Console.WriteLine("3. Delete Result");
                Console.Write("Enter your choice: ");
                int c = int.Parse(Console.ReadLine());
                switch(c)
                {
                    case 1:
                        // Insert new result
                        string result = "PASS";
                        Console.Write("Enter enrollment number: ");
                        string enrollmentNumber = Console.ReadLine();
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("---- Enter Grades ----");
                        Console.Write("DE: ");
                        string de = Console.ReadLine();
                        Console.Write("AJAVA: ");
                        string ajava = Console.ReadLine();
                        Console.Write("Web Technologies: ");
                        string wt = Console.ReadLine();
                        Console.Write(".NET: ");
                        string dotnet = Console.ReadLine();
                        Console.Write("SE: ");
                        string se = Console.ReadLine();
                        Console.Write("TOC: ");
                        string toc = Console.ReadLine();
                        if (de == "FF" || ajava == "FF" || dotnet == "FF" || se == "FF" || toc == "FF" || wt == "FF")
                            result = "FAIL"; // :(
                                             // string query = "INSERT INTO `be_sem_6` (`name`, `DOTNET`, `AJAVA`, `SE`, `WT`, `DE`, `TOC`, `enrollmentNumber`, `result`) VALUES(" + @name.ToString() + "," + @dotnet +", "+ @ajava + "," + @se + ", " + @wt + ", " + @de + ", " + @toc + ", " + @enrollmentNumber + ", " + @result + ");";
                        string query = "INSERT INTO `be_sem_6` (`name`, `DOTNET`, `AJAVA`, `SE`, `WT`, `DE`, `TOC`, `enrollmentNumber`, `result`) VALUES(@name, @dotnet, @ajava, @se, @wt, @de, @toc, @en, @result);";
                       
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.Add("@name", MySqlDbType.String).Value = name;
                        cmd.Parameters.Add("@dotnet", MySqlDbType.String).Value = dotnet;
                        cmd.Parameters.Add("@ajava", MySqlDbType.String).Value = ajava;
                        cmd.Parameters.Add("@se", MySqlDbType.String).Value = se;
                        cmd.Parameters.Add("@wt", MySqlDbType.String).Value = wt;
                        cmd.Parameters.Add("@de", MySqlDbType.String).Value = de;
                        cmd.Parameters.Add("@toc", MySqlDbType.String).Value = toc;
                        cmd.Parameters.Add("@en", MySqlDbType.String).Value = enrollmentNumber;
                        cmd.Parameters.Add("@result", MySqlDbType.String).Value = result;

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.RecordsAffected > 0)
                            Console.WriteLine("Result Inserted!!");
                        else
                            Console.WriteLine("Result Cannot Insert!!");
                        reader.Close();
                        break;
                    case 2:
                        // Update result by enrollment number
                        result = "PASS";
                        Console.Write("Enter enrollment number: ");
                        enrollmentNumber = (Console.ReadLine()).Trim();
                        if (enrollmentNumber.Length > 0)
                        {
                            Console.WriteLine("::Enter Grades::");
                            Console.Write("DE: ");
                            de = Console.ReadLine();
                            Console.Write("AJAVA: ");
                            ajava = Console.ReadLine();
                            Console.Write("Web Technologies: ");
                            wt = Console.ReadLine();
                            Console.Write(".NET: ");
                            dotnet = Console.ReadLine();
                            Console.Write("SE: ");
                            se = Console.ReadLine();
                            Console.Write("TOC: ");
                            toc = Console.ReadLine();
                            if (de == "FF" || ajava == "FF" || dotnet == "FF" || se == "FF" || toc == "FF" || wt == "FF")
                                result = "FAIL"; // :(
                                                 // string query = "INSERT INTO `be_sem_6` (`name`, `DOTNET`, `AJAVA`, `SE`, `WT`, `DE`, `TOC`, `enrollmentNumber`, `result`) VALUES(" + @name.ToString() + "," + @dotnet +", "+ @ajava + "," + @se + ", " + @wt + ", " + @de + ", " + @toc + ", " + @enrollmentNumber + ", " + @result + ");";
                            query = "UPDATE `be_sem_6` SET DOTNET=@dotnet, AJAVA=@ajava, SE=@se, WT=@wt, DE=@de, TOC=@toc, RESULT=@result WHERE `enrollmentNumber`="+enrollmentNumber;

                            cmd = new MySqlCommand(query, con);
            
                            cmd.Parameters.Add("@dotnet", MySqlDbType.String).Value = dotnet;
                            cmd.Parameters.Add("@ajava", MySqlDbType.String).Value = ajava;
                            cmd.Parameters.Add("@se", MySqlDbType.String).Value = se;
                            cmd.Parameters.Add("@wt", MySqlDbType.String).Value = wt;
                            cmd.Parameters.Add("@de", MySqlDbType.String).Value = de;
                            cmd.Parameters.Add("@toc", MySqlDbType.String).Value = toc;
                            // cmd.Parameters.Add("@en", MySqlDbType.String).Value = enrollmentNumber;
                            cmd.Parameters.Add("@result", MySqlDbType.String).Value = result;
                            // cmd.Parameters.Add("@enrollmentNumber", MySqlDbType.String).Value = enrollmentNumber;
                            reader = cmd.ExecuteReader();
                            if (reader.RecordsAffected > 0)
                                Console.WriteLine("Result Updated!!");
                            else
                                Console.WriteLine("Result Cannot Update!!");

                            reader.Close();
                        }
                        else
                            Console.WriteLine("Enter valid enrollment number");
                        break;
                    case 3:
                        // delete result by enrollment number
                        Console.Write("Enter enrollment number: ");
                        enrollmentNumber = (Console.ReadLine()).Trim();
                        if (enrollmentNumber.Length > 0)
                        {
                            query = "DELETE FROM `be_sem_6` where `enrollmentNumber`=" + enrollmentNumber;
                            cmd = new MySqlCommand(query, con);
                            reader = cmd.ExecuteReader();
                            if (reader.RecordsAffected > 0)
                                Console.WriteLine("Result Deleted!!");
                            else
                                Console.WriteLine("Result Cannot Delete!!");
                            reader.Close();
                        }
                        else
                            Console.WriteLine("Enter valid enrollment number!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;
                }
                
            }
        
        } 
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
