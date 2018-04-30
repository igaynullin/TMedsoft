using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TMedsoft.Data.Entities;
using TMedsoft.Data.Migrations;

namespace TMedsoft.Data.Repositories
{
    public class MigrateRepository
    {
        private string _provider;
        private string _connectionString;
        private DbProviderFactory _dbFactory;

        public MigrateRepository()

        {
#if DEBUG

#endif
            _provider = ConfigurationManager.AppSettings["Provider"];
            _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            _dbFactory = DbProviderFactories.GetFactory(_provider);
        }

        public void Migrate()
        {
            try
            {
                using (var connection = _dbFactory.CreateConnection())

                {
                    connection.ConnectionString = _connectionString;
                    if (_provider == "System.Data.SqlClient")
                    {
                        var sql = @"IF (EXISTS (SELECT *
                        FROM INFORMATION_SCHEMA.TABLES
                        WHERE TABLE_SCHEMA = 'dbo'
                        AND TABLE_NAME = '{0}'))
                        BEGIN
                            Select count(*) from {0} b
                            END";
                        if (connection.ExecuteScalar<int>(string.Format(sql, "ref_Genres")) == 0)
                            connection.Execute(Sql.dbo_ref_Genres_data);
                        if (connection.ExecuteScalar<int>(string.Format(sql, "ref_Books")) == 0)
                            connection.Execute(Sql.dbo_ref_Books_data);
                        if (connection.ExecuteScalar<int>(string.Format(sql, "ref_Discounts")) == 0)
                            connection.Execute(Sql.dbo_ref_Discounts_data);

                        if (connection.ExecuteScalar<int>(string.Format(sql, "ref_DiscountGenres")) == 0)

                            connection.Execute(Sql.dbo_ref_DiscountGenres_data);
                        if (connection.ExecuteScalar<int>(string.Format(sql, "ref_DiscountBooks")) == 0)
                            connection.Execute(Sql.dbo_ref_DiscountBooks_data);
                        if (connection.ExecuteScalar<int>(string.Format(sql, "doc_Orders")) == 0)
                            connection.Execute(Sql.dbo_doc_Orders_data);
                        if (connection.ExecuteScalar<int>(string.Format(sql, "doc_OrderBooks")) == 0)
                            connection.Execute(Sql.dbo_doc_OrderBooks_data);
                    }
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
        }
    }
}