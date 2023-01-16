namespace dal;
using MySql.Data.MySqlClient;
using vehicle;
public class DbManager{

public static String str=@"server=localhost;port=3306;user=root;password=welcome@123;database=vehicleinfo";

public static List<Vehicle> getallvehical(){
    List<Vehicle> emplist = new List<Vehicle>();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            String q1= "select * from vehicle";
            MySqlCommand cmd =new MySqlCommand(q1,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                Vehicle v = new Vehicle{
                    id=int.Parse(reader["id"].ToString()),
                    name=reader["name"].ToString(),
                    company = reader["company"].ToString(),
                    price = reader["price"].ToString(),
                    engine = reader["engine"].ToString()
                };
                Console.WriteLine(v);
                emplist.Add(v);
            }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }
    return emplist;
}

public static void delvehicle( int id){
    List<Vehicle> vehiclelist = new List<Vehicle>();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            String q1= "delete from vehicle where id="+id;
            MySqlCommand cmd =new MySqlCommand(q1,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            // while(reader.Read()){
            //     Employee emp = new Employee{
            //         eid=int.Parse(reader["eid"].ToString()),
            //         ename=reader["ename"].ToString(),
            //         edept = reader["edept"].ToString()
            //     };
            //     Console.WriteLine(emp);
            //     emplist.Add(emp);
            // }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }
   
}
public static Vehicle findvehicle(int id){
    Vehicle v=new Vehicle();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            String q1= "select * from vehicle where id="+id;
            MySqlCommand cmd =new MySqlCommand(q1,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                 v = new Vehicle{
                    id=int.Parse(reader["id"].ToString()),
                    name=reader["name"].ToString(),
                    company = reader["company"].ToString()
                };
                Console.WriteLine(v);
               
            }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }
    return v;
}

public static void insertvehicle(Vehicle v){
    List<Vehicle> vehiclelist = new List<Vehicle>();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            String q1= $"insert into vehicle  (id,name,company,price,engine) values ('{v.id}','{v.name}','{v.company}','{v.price}','{v.engine}')";
            MySqlCommand cmd =new MySqlCommand(q1,con);
            cmd.ExecuteNonQuery();
            // while(reader.Read()){
            //     Employee emp = new Employee{
            //         eid=int.Parse(reader["eid"].ToString()),
            //         ename=reader["ename"].ToString(),
            //         edept = reader["edept"].ToString()
            //     };
            //     Console.WriteLine(emp);
            //     emplist.Add(emp);
            // }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }
    
}

public static void updatevehicle(Vehicle v){
    List<Vehicle> vehiclelist = new List<Vehicle>();
    
        MySqlConnection con= new MySqlConnection(str);
        try
        {
            con.Open();
            Console.WriteLine(v.id);
            String q1= $"update vehicle set id='{v.id}',name='{v.name}',company='{v.company}',price='{v.price}',engine='{v.engine}' where id="+v.id;
            MySqlCommand cmd =new MySqlCommand(q1,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            // while(reader.Read()){
            //     Employee emp = new Employee{
            //         eid=int.Parse(reader["eid"].ToString()),
            //         ename=reader["ename"].ToString(),
            //         edept = reader["edept"].ToString()
            //     };
            //     Console.WriteLine(emp);
            //     emplist.Add(emp);
            // }

            
        }
        catch (System.Exception)
        {

        }
        finally{
            con.Close();
        }

}}