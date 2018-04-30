using System;
using System.Collections.Generic;

using System.Configuration;
using System.Data;
using System.Data.Common;

using Dapper;
using TMedsoft.Data.Entities;

namespace TMedsoft.Data.Repositories
{
    public class BookRepository
    {
        private readonly string _connectionString;
        private readonly DbProviderFactory _dbFactory;
        private readonly SqlFactory _sqlFactory;
        private readonly Book _entityTemplate;
        private readonly string _provider;

        public BookRepository(string connectionStringKey, string connectionProviderKey)

        {
            _connectionString = ConfigurationManager.AppSettings[connectionStringKey];
            _dbFactory = DbProviderFactories.GetFactory(ConfigurationManager.AppSettings[connectionProviderKey]);
            _sqlFactory = new SqlFactory(connectionProviderKey);
        }

        public BookRepository() : this("ConnectionString", "Provider")

        {
        }

        public IEnumerable<Book> Page(int pageNumber, int rowsPerPage, long? genreId, string name, out int rows)
        {
            IEnumerable<Book> result;
            try
            {
                using (var connection = _dbFactory.CreateConnection())

                {
                    var sql = _sqlFactory.Page(
                          tableName: $"ref_{nameof(Book)}s b"
                        , selectColumns: $"b.[{nameof(_entityTemplate.ID)}], b.[{nameof(_entityTemplate.Name)}], b.[{nameof(_entityTemplate.GenreID)}], b.[{nameof(_entityTemplate.Cost)}], b.[{nameof(_entityTemplate.Quantity)}], g.[{nameof(_entityTemplate.Genre.ID)}], g.[{nameof(_entityTemplate.Genre.Name)}], d.[CouponCode]"
                        , join: $@"left join ref_{nameof(Genre)}s g on b.[{nameof(_entityTemplate.GenreID)}] =g.[{nameof(_entityTemplate.Genre.ID)}] left join ref_DiscountBooks db on b.ID = db.BookID left join ref_DiscountGenres dg on g.ID = dg.GenreID left join ref_Discounts d on d.ID = db.DiscountID or d.ID = dg.DiscountID "
                        , whereClause: $"where (b.[{nameof(_entityTemplate.GenreID)}] = @genreId or @genreId is null) and ( b.[{nameof(_entityTemplate.Name)}]  like CONCAT('%',@name,'%')  or @name is null )"
                        , orderBy: $"b.[{nameof(_entityTemplate.ID)}]"
                        , rowsPerPage: 1
                        , pageNumber: 20
                        );
                    var sql_count = _sqlFactory.Count(
                        tableName: $"ref_{nameof(Book)}s b"
                        , selectColumns: $"b.[{nameof(_entityTemplate.ID)}]"
                        , whereClause: $"where (b.[{nameof(_entityTemplate.GenreID)}] = @genreId or @genreId is null) and  (b.[{nameof(_entityTemplate.Name)}]  like CONCAT('%',@name,'%') or @name is null )"

                    );
                    connection.ConnectionString = _connectionString;
                    rows = connection.ExecuteScalar<int>(sql_count, param: new
                    {
                        genreId,
                        name
                    });
                    result = connection.Query<Book, Genre, Book>(sql, (book, genre) => { book.Genre = genre; return book; }, param: new
                    {
                        genreId,
                        name,
                        pageNumber,
                        rowsPerPage
                    });
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

        //public bool Update(Book entity)
        //{
        //    IEnumerable<Book> result;
        //    try
        //    {
        //        using (var connection = _dbFactory.CreateConnection())
        //        {
        //            IDbTransaction transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
        //            var sql = _sqlFactory.Update(
        //                tableName: $"ref_{nameof(Book)}s b"
        //                ,updateColumns:""
        //                ,whereClause:$" where b.[{entityTemplate.ID}]=@{entityTemplate.ID} "

        //            );

        //            connection.ConnectionString = _connectionString;
        //            connection.Open();
        //            result = connection.ExecuteScalar(sql, (book, genre) => { book.Genre = genre; return book; }, param: new
        //            {
        //                genreId,
        //                name = $"%{name}%"
        //            });
        //            transaction.Commit();
        //            connection.Close();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //    finally
        //    {
        //    }

        //    return result;
        //}

        public IEnumerable<Book> Select(List<long> Ids)
        {
            IEnumerable<Book> result;
            try
            {
                using (var connection = _dbFactory.CreateConnection())
                {
                    connection.ConnectionString = _connectionString;

                    var sql = _sqlFactory.Select(
                          tableName: $"ref_{nameof(Book)}s b"
                        , selectColumns: "b.*"
                        , whereClause: $" where b.[{nameof(_entityTemplate.ID)}] in @Ids"
                        , orderBy: $"b.[{nameof(_entityTemplate.ID)}]"
                    );
                    result = connection.Query<Book>(sql, Ids);
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