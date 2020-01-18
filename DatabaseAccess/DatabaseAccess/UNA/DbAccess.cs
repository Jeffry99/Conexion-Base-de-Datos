using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DatabaseAccess.UNA
{
    abstract class DbAccess
    {
        public abstract string ConnectionString
        {
            get;
            set;
        }
        public abstract DbTransaction Transaction 
        {
            get;
            set;
        }
        public abstract DbConnection Connection 
        {
            get;
            set;
        }

        public void OpenConnection()
        {

        }
        public void CloseConnection()
        {

        }
    
        public long EjectSQL(String var)
        {
            return 0;
        }
        public DataTable QuerySQL(string var)
        {
            return null;
        }
        public bool IsTransaction()
        {
            return true;
        }
        public void CommitTransaction()
        {

        }
        public void RollBackTransaction()
        {

        }
        public void BeginTransaction()
        {

        }

    }
}
