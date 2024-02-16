using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionEtudiant.back.core.impl
{
    public class DataBase : IDataBase
    {
        private readonly string  connectionString= ConfigurationManager.ConnectionStrings["GES_ETU"].ConnectionString;
        private SqlConnection sqlConnection=new SqlConnection();
        //Relation =  Objet
        private SqlDataAdapter adapter=new SqlDataAdapter();
        protected string TableName;

        public void CloseConnexion()
        {
            if (sqlConnection.State == ConnectionState.Open || sqlConnection.State == ConnectionState.Connecting)
            {
                sqlConnection.Close();
            }
        }

        public DataTable ExecuteSelect(string sql)
        {
            try
            {
                    OpenConnexion();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = sql;
                    adapter.SelectCommand = sqlCommand;//Data en Objet
                    DataSet demon = new DataSet();//Base Donnee
           
                     if (demon.Tables[TableName]!=null)
                      {
                        demon.Tables[TableName].Clear();
                      }
                       adapter.Fill(demon, TableName) ;
                       CloseConnexion();

                    return demon.Tables[TableName];

            }
            catch (Exception)
            {
                throw;
            }

        }

        public int ExecuteUpdate(string sql)
        {
            try
            {
           
                OpenConnexion();
                SqlCommand sqlCommand = new SqlCommand();
                int nbrLigne = 0;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = sql;
                adapter.SelectCommand = sqlCommand;
                if (sql.ToLower().StartsWith("insert"))
                {
                     nbrLigne=Convert.ToInt32(sqlCommand.ExecuteScalar());
                }
                else
                {
                    nbrLigne= sqlCommand.ExecuteNonQuery();
                }
                CloseConnexion();
                return nbrLigne;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void OpenConnexion()
        {
            if (sqlConnection.State== ConnectionState.Closed || sqlConnection.State== ConnectionState.Broken)
            {
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();
            }
           
        }
    }
}
