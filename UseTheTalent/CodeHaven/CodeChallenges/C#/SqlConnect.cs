using System.Data.SqlClient;

SqlConnection myConnection = new SqlConnection ("user id=username;" +
												"password=password;server=serverurl;" +
												"Trusted_Connection=yes;" + 
												"database=database; " + 
												"connection timeout=30");

SqlConnection.Open(){
try
{
	myConnection.Open();
	}	
catch(Exception e)
{
	Console.WriteLine(e.ToString());
	}
};												
	SqlCommand myCommand = new SqlCommand("Select * from table WHERE table = 'userMaster'", myConnection);
	