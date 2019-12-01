using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DatabaseHandler
    {
        //Attributes.
        private SqlConnection DBConnection;
        private SqlDataAdapter DataAdapter;
        private DataSet ResultSet;
        private SqlCommand QueryCommand;
        private SqlDataReader QueryResultReader;
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 

        //Constructor.
        public DatabaseHandler()
        {
            DBConnection = new SqlConnection(@"Data Source=DESKTOP-ED4GQK7;Initial Catalog=Chess Consortium;Integrated Security=True");
            DBConnection.Open();
            ResultSet = new DataSet();
        }
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 

        //Methods.
        public void ConnectToDB(string s)
        {
            DBConnection = new SqlConnection(@"Data Source=DESKTOP-ED4GQK7;Initial Catalog=" + s + ";Integrated Security=True");
            DBConnection.Open();
            ResultSet = new DataSet();
        }
        //---------------------------------------------------------------------------------------------- 

        public DataSet ExceuteQuerySet(string Query)
        {
            DataAdapter = new SqlDataAdapter(Query, DBConnection);
            DataAdapter.Fill(ResultSet, "myTable");
            DataAdapter.Dispose();
            return ResultSet;
        }
        //---------------------------------------------------------------------------------------------- 
        public SqlDataReader ExceuteQuery(string Query)
        {
            QueryCommand = new SqlCommand(Query, DBConnection);
            QueryResultReader = QueryCommand.ExecuteReader();
            QueryCommand.Dispose();
            return QueryResultReader;
        }
        //---------------------------------------------------------------------------------------------- 
        public int UpdateQuery(string Query)
        {
            QueryCommand = new SqlCommand(Query, DBConnection);
            int Result = QueryCommand.ExecuteNonQuery();
            QueryCommand.Dispose();
            return Result;

        }
        //----------------------------------------------------------------------------------------------
        public int InsertQuery(string Query)
        {
            QueryCommand = new SqlCommand(Query, DBConnection);
            int Result = QueryCommand.ExecuteNonQuery();
            QueryCommand.Dispose();
            return Result;

        }
        //---------------------------------------------------------------------------------------------- 
        public int UpdateQuerySet(DataSet ds, string Query)
        {
            DataAdapter = new SqlDataAdapter(Query, DBConnection);
            DataAdapter.Fill(ResultSet);
            ResultSet = ds.Copy();
            int Result = DataAdapter.Update(ResultSet);
            DataAdapter.Dispose();
            return Result;
        }
        //---------------------------------------------------------------------------------------------- 
        public object SpecificQuery(string Query)
        {
            QueryCommand = new SqlCommand(Query, DBConnection);
            object Result = QueryCommand.ExecuteScalar();
            QueryCommand.Dispose();
            return Result;
        }
        //---------------------------------------------------------------------------------------------- 
        public void CloseConnection()
        {
            DBConnection.Close();
        }
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 

    }//End Class.
}//End Namespace.
