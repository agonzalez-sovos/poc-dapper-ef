using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Domain.Core
{
    public interface ISql
    {
        T Single<T>(string sql, object param = null);
        T First<T>(string sql, object param = null);
        IEnumerable<T> Query<T>(string sql, object param = null);
        int Execute(string sql, object param = null);
        T ExecuteScalar<T>(string sql, object param = null);
    }
}
