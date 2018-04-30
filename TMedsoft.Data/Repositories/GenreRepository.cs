using System;
using System.Collections.Generic;

using System.Configuration;
using System.Data.Common;

using Dapper;
using TMedsoft.Data.Entities;
using TMedsoft.Interfaces;
using TMedsoft.ViewModels;

namespace TMedsoft.Data.Repositories
{
    public class GenreRepository
    {
        private readonly string _connectionString;
        private readonly DbProviderFactory _dbFactory;
        private readonly SqlFactory _sqlFactory;
        private readonly string _provider;
        private readonly Genre entityTemplate;

        public GenreRepository(string connectionStringKey, string connectionProviderKey)

        {
            _connectionString = ConfigurationManager.AppSettings[connectionStringKey];
            _dbFactory = DbProviderFactories.GetFactory(ConfigurationManager.AppSettings[connectionProviderKey]);
            _sqlFactory = new SqlFactory(connectionProviderKey);
        }

        public GenreRepository() : this("ConnectionString", "Provider")

        {
        }

        public IEnumerable<ILookup> GetLookup()
        {
            IEnumerable<ILookup> result;
            try
            {
                using (var connection = _dbFactory.CreateConnection())
                {
                    var sql = _sqlFactory.Select(
                          tableName: $"ref_{nameof(Genre)}s b"
                        , selectColumns: $"b.[{nameof(entityTemplate.ID)}] as {nameof(Lookup.Value)}, b.[{nameof(entityTemplate.Name)}] as {nameof(Lookup.Text)}"
                        , whereClause: ""
                        , orderBy: $"b.[{nameof(entityTemplate.Name)}]"
                    );

                    connection.ConnectionString = _connectionString;
                    result = connection.Query<Lookup>(sql);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
            }

            return result;
        }
    }
}