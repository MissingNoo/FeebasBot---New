using System;
using System.Data;
using System.Data.SQLite;

namespace csharp_Sqlite
{
    public class DalHelper
    {
        private static SQLiteConnection sqliteConnection;

        public DalHelper()
        { }

        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=cavebot.sqlite; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public static void CriarBancoSQLite()
        {
            try
            {
                SQLiteConnection.CreateFile(@"cavebot.sqlite");
            }
            catch
            {
                throw;
            }
        }

        public static void CriarTabelaSQlite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS cbot(id int, Comando Char(255), X int(100), Y int(100), Option Char(100))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetClientes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM cbot";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetCliente(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM cbot Where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Add(int id, string Comando, int X, int Y, string Option)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO cbot(id, Comando, X, Y, Option ) values (@id, @Comando, @X, @Y, @Option)";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@Comando", Comando);
                    cmd.Parameters.AddWithValue("@X", X);
                    cmd.Parameters.AddWithValue("@Y", Y);
                    cmd.Parameters.AddWithValue("@Option", Option);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateID(int idold,int idnew)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                        cmd.CommandText = "UPDATE cbot SET Id=@idnew WHERE Id=@idold";
                        cmd.Parameters.AddWithValue("@idnew", idnew);
                        cmd.Parameters.AddWithValue("@idold", idold);
                        cmd.ExecuteNonQuery();
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Update(int id, string Comando, int X, int Y, string Option)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (id != null)
                    {
                        cmd.CommandText = "UPDATE cbot SET Comando=@Comando, X=@X, Y=@Y, Option=@Option WHERE Id=@id";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@Comando", Comando);
                        cmd.Parameters.AddWithValue("@X", X);
                        cmd.Parameters.AddWithValue("@Y", Y);
                        cmd.Parameters.AddWithValue("@Option", Option);
                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(int Id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM cbot Where Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}