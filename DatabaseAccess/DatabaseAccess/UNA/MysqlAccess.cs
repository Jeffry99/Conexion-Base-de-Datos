using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DatabaseAccess.UNA
{
    class MysqlAccess : DbAccess
    {
        public override string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DbTransaction Transaction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DbConnection Connection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
