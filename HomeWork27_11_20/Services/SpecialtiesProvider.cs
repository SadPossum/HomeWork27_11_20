using HomeWork27_11_20.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HomeWork27_11_20.Services
{
    public class SpecialtiesProvider
    {
        private SqlConnection _connection;

        public SpecialtiesProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Specialty> GetAll()
        {
            List<Specialty> result = new List<Specialty>();

            try
            {
                _connection.Open();
                var command = new SqlCommand(
                    cmdText: "SELECT [id], [code], [name] FROM [Specialties]",
                    connection: _connection
                    );

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var specialty = new Specialty
                        {
                            Id = reader.GetInt32(0),
                            Code = reader.GetString(1),
                            Name = reader.GetString(2)
                        };

                        result.Add(specialty);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Add(Specialty specialty)
        {
            bool result = false;

            try
            {
                _connection.Open();
                var command = new SqlCommand(
                    cmdText: @"
                        INSERT INTO [Specialties]
                            ([code], [name])
                        VALUES
                            (@Code, @Name)
                        ",
                    connection: _connection
                );

                command.Parameters.AddWithValue("@Code", specialty.Code);
                command.Parameters.AddWithValue("@Name", specialty.Name);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Update(int id, Specialty newValue)
        {
            bool result = false;

            try
            {
                _connection.Open();
                var command = new SqlCommand(
                    cmdText: @"
                        UPDATE [Specialties] 
                        SET
                            [code] = @Code
                            [name] = @Name
                        WHERE 
                            [id] = @Id
                        ",
                    connection: _connection
                );
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Code", newValue.Code);
                command.Parameters.AddWithValue("@Name", newValue.Name);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;

            try
            {
                _connection.Open();
                var command = new SqlCommand(
                    cmdText: @"
                        DELETE FROM [Specialties]
                        WHERE [id] = @Id
                        ",
                    connection: _connection
                );
                command.Parameters.AddWithValue("@Id", id);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }
    }
}
