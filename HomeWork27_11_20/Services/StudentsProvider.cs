using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork27_11_20.Models;

namespace HomeWork27_11_20.Services
{
    class StudentsProvider
    {
        private SqlConnection _connection;

        public StudentsProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Student> GetAll()
        {
            List<Student> result = new List<Student>();

            try
            {
                _connection.Open();
                var command = new SqlCommand(
                    cmdText: @"
                        SELECT
                            [Students].[id],
                            [Students].[name],
                            [Students].[surname],
                            [Students].[group_id],
                            [Groups].[name],
                            [Groups].[year]
                        FROM [Students]
                        LEFT JOIN [Groups]
                        ON [Groups].[id] = [Students].[group_id]
                        ",
                    connection: _connection
                    );

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var group = new Group
                        {
                            Id = reader.GetInt32(3),
                            Name = reader.GetString(4),
                            Year = reader.GetInt32(5)
                        };

                        var student = new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Surname = reader.GetString(2),
                            GroupId = reader.GetInt32(3),
                            Group = group
                        };

                        result.Add(student);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Add(Student student)
        {
            bool result = false;

            try
            {
                _connection.Open();
                var command = new SqlCommand(
                    cmdText: @"
                        INSERT INTO [Students]
                            ( 
                            [Students].[name],
                            [Students].[surname],
                            [Students].[group_id]
                            )
                        VALUES
                            (@Name, @Surname, @GroupId)
                        ",
                    connection: _connection
                );

                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Surname", student.Surname);
                command.Parameters.AddWithValue("@GroupId", student.GroupId);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Update(int id, Student newValue)
        {
            bool result = false;

            try
            {
                _connection.Open();
                var command = new SqlCommand(
                    cmdText: @"
                        UPDATE [Specialties] 
                        SET
                            [name] = @Name
                            [surname] = @Surname
                            [specialty_id] = @GroupId
                        WHERE 
                            [id] = @Id
                        ",
                    connection: _connection
                );
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Surname", newValue.Surname);
                command.Parameters.AddWithValue("@GroupId", newValue.GroupId);

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
                        DELETE FROM [Students]
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
