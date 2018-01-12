﻿using LinFx.Data;
using LinFx.Data.Extensions;
using LinFx.Data.Extensions.Mapper;
using LinFx.Data.Extensions.Sql;
using LinFx.Data.Provider;
using System.Collections.Generic;
using System.Reflection;

namespace LinFx.Utils
{
    public static class DbUtils
    {
        public static IDatabase GetPostgreSqlDatabase(string connectionString)
        {
            var factory = new DbConnectionFactory(connectionString, PostgreSqlProvider.Instance);
            var config = new DataAccessExtensionsConfiguration(typeof(AutoClassMapper<>), new List<Assembly>(), new PostgreSqlDialect());
            return new Database(factory.Create(), new SqlGeneratorImpl(config));
        }

        public static IDatabase GetMySqlDatabase(string connectionString)
        {
            var factory = new DbConnectionFactory(connectionString, MySqlProvider.Instance);
            var config = new DataAccessExtensionsConfiguration(typeof(AutoClassMapper<>), new List<Assembly>(), new MySqlDialect());
            return new Database(factory.Create(), new SqlGeneratorImpl(config));
        }
    }
}