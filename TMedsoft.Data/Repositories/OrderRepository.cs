using System;
using System.Collections.Generic;

using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Text;
using Dapper;
using TMedsoft.Data.Entities;

namespace TMedsoft.Data.Repositories
{
    public class OrderRepository
    {
        private readonly string _connectionString;
        private readonly DbProviderFactory _dbFactory;
        private readonly SqlFactory _sqlFactory;
        private readonly Order entityTemplate;

        public OrderRepository(string connectionStringKey, string connectionProviderKey)

        {
            _connectionString = ConfigurationManager.AppSettings[connectionStringKey];
            _dbFactory = DbProviderFactories.GetFactory(ConfigurationManager.AppSettings[connectionProviderKey]);
            _sqlFactory = new SqlFactory(connectionProviderKey);
        }

        public OrderRepository() : this("ConnectionString", "Provider")

        {
        }

        public long Insert(Order entity)
        {
            var result = 0;

            using (var connection = _dbFactory.CreateConnection())
            using (var transaction = connection.BeginTransaction(IsolationLevel.Serializable))
            {
                try
                {
                    var sql = new StringBuilder();
                    sql.Append(
                        $"Insert into ref_{nameof(Order)}s(@{nameof(entityTemplate.Quantity)},@{nameof(entityTemplate.Cost)}) OUTPUT Inserted.ID Values(@{nameof(entityTemplate.Quantity)},@{nameof(entityTemplate.Cost)}) ");
                    var id = connection.ExecuteScalar<long>(sql.ToString(), transaction);
                    sql.Clear();
                    foreach (var book in entity.Books)
                    {
                        sql.Append($"Update ref_Books set Quantity= Quantity-{book.Quantity} where ID ={book.BookID} and Quantity-{book.Quantity} >0");
                        sql.Append($"Insert into doc_OrderBooks(OrderID,BookID, {nameof(entityTemplate.Quantity)},{nameof(entityTemplate.Cost)}) Values({id},{book.BookID}{book.Quantity},{book.Cost}) "); /// Very bad
                    }

                    connection.ConnectionString = _connectionString;

                    transaction.Commit();
                    connection.Close();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                }
            }

            return result;
        }
    }
}