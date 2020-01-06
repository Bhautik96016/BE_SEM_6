/*
If you're doing it "plain vanilla" in the command console, then you need to specify the path to the JAR file in the -cp or -classpath argument when executing your Java application.

java -cp .;/path/to/mysql-connector.jar com.example.YourClass
The . is just there to add the current directory to the classpath as well so that it can locate com.example.YourClass and the ; is the classpath separator as it is in Windows. In Unix and clones : should be used.

$ java -cp .;mysql-connector.jar bhautik.FirstLect

*/

package bhautik;

import java.util.*;
import java.sql.*;

public class FirstLect {

    static final String DRIVER = "com.mysql.jdbc.Driver";
    static final String DATABASE = "jdbc:mysql://localhost:3306/Employee";
    static final String USERNAME = "root";
    static final String PASSWORD = "";

    public static void main(String[] args) {
        try {
            // Establish a channel
            Class.forName(DRIVER);
            // Create Connection class Object
            Connection con = DriverManager.getConnection(DATABASE, USERNAME, PASSWORD);
            // Prepair Query
            String query = "INSERT INTO emp (userId, name, age) VALUES(?, ?, ?)";
            // SQL statement for run SQL queries
            // Statement stmt = con.createStatement();

            // Prepared Statement
            PreparedStatement ps = con.prepareStatement(query);
            ps.setString(1, "BhaveshGoswami");
            ps.setString(2, "Bhavesh");
            ps.setInt(3, 22);

            int insertedRows = ps.executeUpdate();
            System.out.println("Inserted Rows: "+insertedRows);

            // Run SQL Query and store result into ResultSet
            // ResultSet rs = ps.executeQuery(query);
            /*
            while(rs.next()) {
                System.out.println(rs.getString("name"));
            }
            */
            con.close();
        }
        catch (Exception e) {
            System.out.println(e);
        }
    }
}
