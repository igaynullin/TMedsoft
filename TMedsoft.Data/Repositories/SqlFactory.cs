using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMedsoft.Data.Repositories
{
    internal class SqlFactory
    {
        private readonly string _provider;

        public SqlFactory(string connectionProviderKey)
        {
            _provider = ConfigurationManager.AppSettings[connectionProviderKey];
        }

        public string Page(string tableName, string selectColumns, string join, string whereClause, string orderBy, int rowsPerPage, int pageNumber)
        {
            var sql = "";

            switch (_provider)
            {
                case "System.Data.SqlClient":

                    sql = $"Select {selectColumns} from {tableName} {join} {whereClause} Order By {orderBy}  OFFSET @pageNumber - 1 ROW FETCH NEXT @rowsPerPage ROWS ONLY";
                    break;

                default:
                    break;
            }

            return sql;
        }

        public string Select(string tableName, string selectColumns, string whereClause, string orderBy)
        {
            var sql = "";

            switch (_provider)
            {
                case "System.Data.SqlClient":

                    sql = $"Select {selectColumns} from {tableName} Order By {orderBy} ";
                    break;

                default:
                    break;
            }

            return sql;
        }

        public string Insert(string tableName, string selectColumns, string orderBy)
        {
            var sql = "";

            switch (_provider)
            {
                case "System.Data.SqlClient":

                    sql = $"Select {selectColumns} from {tableName} Order By {orderBy} ";
                    break;

                default:
                    break;
            }

            return sql;
        }

        public string Update(string tableName, string updateColumns, string whereClause)
        {
            var sql = "";

            switch (_provider)
            {
                case "System.Data.SqlClient":

                    sql = $"Update {tableName} set {updateColumns} {whereClause}";
                    break;

                default:
                    break;
            }

            return sql;
        }

        public string Count(string tableName, string selectColumns, string whereClause)
        {
            var sql = "";

            switch (_provider)
            {
                case "System.Data.SqlClient":

                    sql = $"Select COUNT({selectColumns}) from {tableName} {whereClause}";
                    break;

                default:
                    break;
            }

            return sql;
        }
    }
}