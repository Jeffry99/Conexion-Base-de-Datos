using System;
using System.Collections.Generic;
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
        public abstract Transaction DbTransaction
        {

        }
    }
}
