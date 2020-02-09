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

            bool isRunning = true;
            while (isRunning)
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `be_sem_6`", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Console.WriteLine("1. Insert Result");
                Console.WriteLine("2. Update Result");
                Console.WriteLine("3. Delete Result");
                Console.WriteLine("4. Exit Program");
                Console.Write("Enter your choice: ");
                int c = int.Parse(Console.ReadLine());
                switch (c)
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
                        
                       
                        
                        MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                        da.UpdateCommand = build.GetUpdateCommand();
                        DataRow dr = ds.Tables[0].NewRow();
                        dr["name"] = name;
                        dr["enrollmentNumber"] = enrollmentNumber;
                        dr["DOTNET"] = dotnet;
                        dr["RESULT"] = result;
                        dr["AJAVA"] = ajava;
                        dr["SE"] = se;
                        dr["WT"] = wt;
                        dr["DE"] = de;
                        dr["TOC"] = toc;
                        ds.Tables[0].Rows.Add(dr);
                        da.Update(ds);
                        ds.Clear();
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
                            ds.Clear();
                            da = new MySqlDataAdapter("SELECT * FROM `be_sem_6` WHERE `enrollmentNumber`="+enrollmentNumber, con);
                            ds = new DataSet();
                            da.Fill(ds);

                            build = new MySqlCommandBuilder(da);
                            da.UpdateCommand = build.GetUpdateCommand();
                            ds.Tables[0].Rows[0]["DOTNET"] = dotnet;
                            ds.Tables[0].Rows[0]["RESULT"] = result;
                            ds.Tables[0].Rows[0]["AJAVA"] = ajava;
                            ds.Tables[0].Rows[0]["SE"] = se;
                            ds.Tables[0].Rows[0]["WT"] = wt;
                            ds.Tables[0].Rows[0]["DE"] = de;
                            ds.Tables[0].Rows[0]["TOC"] = toc;
                            da.Update(ds);
                       
                            ds.Clear();
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
                            da = new MySqlDataAdapter("SELECT * FROM `be_sem_6` WHERE `enrollmentNumber`=" + enrollmentNumber, con);
                            ds = new DataSet();
                            da.Fill(ds);
                            build = new MySqlCommandBuilder(da);
                            da.DeleteCommand = build.GetDeleteCommand();
                            ds.Tables[0].Rows[0].Delete();
                            da.Update(ds);
                            ds.Clear();
                        }
                        else
                            Console.WriteLine("Enter valid enrollment number!!");
                        break;
                    case 4:
                        isRunning = false;
                        con.Close();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;
                }

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
