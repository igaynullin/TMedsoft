using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using Dapper;
using TMedsoft.Data.Entities;

namespace TMedsoft.Data.Repositories
{
    public class DiscountRepository
    {
        private readonly string _connectionString;
        private readonly DbProviderFactory _dbFactory;
        private readonly SqlFactory _sqlFactory;
        private readonly Book _entityTemplate;
        private readonly string _provider;

        public DiscountRepository(string connectionStringKey, string connectionProviderKey)

        {
            _connectionString = ConfigurationManager.AppSettings[connectionStringKey];
            _dbFactory = DbProviderFactories.GetFactory(ConfigurationManager.AppSettings[connectionProviderKey]);
            _sqlFactory = new SqlFactory(connectionProviderKey);
        }

        public DiscountRepository() : this("ConnectionString", "Provider")

        {
        }

        public IEnumerable<Discount> Get()
        {
            IEnumerable<Discount> result;
            try
            {
                using (var connection = _dbFactory.CreateConnection())

                {
                    var sql = "select d.* from ref_Discounts d select dg.GenreID from ref_DiscountGenres dg select dg.BookID from ref_DiscountBooks db";
                    using (var multi = connection.QueryMultiple(sql))
                    {
                        var discounts = multi.Read<Discount>();
                        var discountGenres = multi.Read<DiscountGenre>().ToList();
                        var discountBooks = multi.Read<DiscountBook>().ToList();

                        foreach (var discount in discounts)
                        {
                            if (discount.TypeDiscount == TypeDiscount.GenderDiscount)
                            {
                                discount.DiscountGenres =
                                    discountGenres.Where(e => e.DiscountID == discount.ID).Select(e => e.GenreID);
                            }
                            else if (discount.TypeDiscount == TypeDiscount.BookDiscount)
                            {
                                discount.DiscountBooks =
                                    discountBooks.Where(e => e.DiscountID == discount.ID).Select(e => e.BookID);
                            }
                        }
                        result = discounts;
                    }

                    connection.ConnectionString = _connectionString;
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return result;
        }
    }
}