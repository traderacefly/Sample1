using System;
using System.Data.SqlClient;
using System.Data;

namespace Samples
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Sample1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			//Set the connection string for the database
			//string connectionstring="Initial Catalog=TestCatalog; Data Source=myDataSource;user id=admin;password=adminadmin;";
            //string tainted_query = "Select medication=" + args[0].Clone() + " from medications";

			//Create Connection and open it
			//System.Data.SqlClient.SqlConnection  conn = new SqlConnection(connectionstring);
			//conn.Open ();

			//Create an adapter object with a clean string
			//SqlDataAdapter adapter = new SqlDataAdapter("Select name, id, from patients", connectionstring);
			//Create an adapter object with a directly tainted string
			//SqlDataAdapter adapter1 = new SqlDataAdapter(args[1], connectionstring);
			//Create an adapter object with a string contructed froma tainted sub-string
			//SqlDataAdapter adapter2 = new SqlDataAdapter(tainted_query, connectionstring);

			//Create a dataset object and fill the values from Employees table
			//DataSet oDataSet = new DataSet();
			//adapter.Fill(oDataSet, "Contents");

            // Create two DataTable instances.
            DataTable table1 = new DataTable("patients");
            table1.Columns.Add("name");
            table1.Columns.Add("id");
            table1.Rows.Add("sam", 1);
            table1.Rows.Add("mark", 2);

            DataTable table2 = new DataTable("medications");
            table2.Columns.Add("id");
            table2.Columns.Add("medication");
            table2.Rows.Add(1, "atenolol");
            table2.Rows.Add(2, "amoxicillin");

            // Create a DataSet and put both tables in it.
            DataSet set = new DataSet("office");
            set.Tables.Add(table1);
            set.Tables.Add(table2);

            //Create a dataset object and fill the values from Employees table
            //adapter.Fill(set, "Contents");

            //Print the records in XML format
            Console.WriteLine(set.GetXml());

        }
    }
}