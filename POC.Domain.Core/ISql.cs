using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Domain.Core
{
    public interface ISql : IDisposable
    {
        T Single<T>(string sql, object param = null);
        T First<T>(string sql, object param = null);
        IEnumerable<T> Query<T>(string sql, object param = null);
        int Excecute(string sql, object param = null);
        T ExcecuteScalar<T>(string sql, object param = null);
    }
}
