using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace OnlineShop.DataAccess
{
    class DataBaseHelper:DataAccessBase
    {
        private SqlParameter[] _Parameters;

        public DataBaseHelper(string storedProcedureName)
        {
            base.StoredProcedureName = storedProcedureName;
        }
        public void Run(SqlTransaction transaction)
        {
            SqlHelper.ExecuteNonQuery(transaction, CommandType.StoredProcedure, 
                StoredProcedureName, Parameters);
        }
        public void Run(SqlTransaction transaction,SqlParameter[] parameters)
        {
            SqlHelper.ExecuteNonQuery(transaction, CommandType.StoredProcedure,
                StoredProcedureName, parameters);
        }
        public DataSet Run(String connectionString, SqlParameter[] parameters)
        {
            DataSet ds;
            ds = SqlHelper.ExecuteDataset(connectionString, StoredProcedureName, parameters);
            return ds;
        }
        public DataSet Run(String connectionString,CommandType cmdType,params SqlParameter[] parameters)
        {
            DataSet ds;
            ds = SqlHelper.ExecuteDataset(connectionString,cmdType, StoredProcedureName, parameters);

            return ds;
        }
        public object RunScalar(SqlTransaction transaction, SqlParameter[] parameters)
        {
            object obj;
            obj = SqlHelper.ExecuteScalar(ConnectionString, StoredProcedureName, parameters);
           
            return obj;
        }
        public object RunScalar(String connectionString, SqlParameter[] parameters)
        {
            object obj;
            obj = SqlHelper.ExecuteScalar(ConnectionString, StoredProcedureName, parameters);
            return obj;
        }
        public DataSet Run(string connectionString)
        {
            DataSet ds;
            ds = SqlHelper.ExecuteDataset(connectionString,CommandType.StoredProcedure,StoredProcedureName);
            return ds;
        }
        public void Run()
        {
            SqlHelper.ExecuteNonQuery(base.ConnectionString,CommandType.StoredProcedure,StoredProcedureName,Parameters);
        }
        public SqlDataReader Run(SqlParameter[] parameters)
        {
            SqlDataReader dr;
            dr = SqlHelper.ExecuteReader(base.ConnectionString, CommandType.StoredProcedure, StoredProcedureName, parameters);
            return dr;
        }
        public SqlParameter[] Parameters
        {
            get { return _Parameters; }
            set { _Parameters = value; }
        }
    }
}
