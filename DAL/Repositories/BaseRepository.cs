using DAL.Interfaces;

namespace DAL.Repositories
{
    using MySql.Data.MySqlClient;
    using System.Collections.Generic;
    using System.Data;

    public abstract class BaseRepository<T> : IRepository<T>
    {
        protected readonly Connection _connection;

        protected BaseRepository()
        {
            _connection = new Connection();  
        }

        public virtual IEnumerable<T> GetAll()
        {
            var list = new List<T>();
            using var conn = _connection.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand(GetSelectAllQuery(), conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
                list.Add(Map(reader));

            return list;
        }

        public virtual T GetById(int id)
        {
            using var conn = _connection.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand(GetSelectByIdQuery(), conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = cmd.ExecuteReader();

            return reader.Read() ? Map(reader) : default;
        }

        public virtual int Add(T entity)
        {
            using var conn = _connection.GetConnection();
            conn.Open();
            var query = GetInsertQuery() + Environment.NewLine;
            query += "SELECT LAST_INSERT_ID();";
            using var cmd = new MySqlCommand(query, conn);
            AddParameters(cmd, entity);
            int r = Convert.ToInt32(cmd.ExecuteScalar());
            return r;
        }

        public virtual void Update(T entity)
        {
            using var conn = _connection.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand(GetUpdateQuery(), conn);
            SetUpdateParameters(cmd, entity);
            cmd.ExecuteNonQuery();
        }

        public virtual void Delete(int id)
        {
            using var conn = _connection.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand(GetDeleteQuery(), conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        // Abstractos que implementan los hijos
        protected abstract T Map(IDataReader reader);
        protected abstract string GetSelectAllQuery();
        protected abstract string GetSelectByIdQuery();
        protected abstract string GetInsertQuery();
        protected abstract string GetUpdateQuery();
        protected abstract string GetDeleteQuery();
        protected abstract void AddParameters(MySqlCommand cmd, T entity);
        protected abstract void SetUpdateParameters(MySqlCommand cmd, T entity);

        public IEnumerable<T> GetAllWithParam(string query)
        {
            var list = new List<T>();
            using var conn = _connection.GetConnection();
            conn.Open();

            using var cmd = new MySqlCommand(GetSelectAllQuery() + query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
                list.Add(Map(reader));

            return list;
        }
    }
}
