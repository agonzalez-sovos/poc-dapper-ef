using Dapper;
using POC.Domain.Core;
using System;
using System.Collections.Generic;
using System.Data;

namespace POC.Infrastructure.Data
{
    public class Sql : ISql, IDisposable
    {
        private readonly IDbConnection _conn;

        public Sql(IDbConnection connection)
        {
            _conn = connection;
        }

        public int Execute(string sql, object param = null)
        {
            return _conn.Execute(sql, param);
        }

        public T ExecuteScalar<T>(string sql, object param = null)
        {
            return _conn.ExecuteScalar<T>(sql, param);
        }

        public T First<T>(string sql, object param = null)
        {
            return _conn.QueryFirstOrDefault<T>(sql, param);
        }

        public IEnumerable<T> Query<T>(string sql, object param = null)
        {
            return _conn.Query<T>(sql, param);
        }

        public T Single<T>(string sql, object param = null)
        {
            return _conn.QuerySingleOrDefault<T>(sql, param);
        }

        public void Dispose()
        {
            _conn.Dispose();
        }
    }
}
