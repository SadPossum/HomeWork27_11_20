﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork27_11_20.Models;

namespace HomeWork27_11_20.Services
{
    public class GroupsProvider
    {
        private SqlConnection _connection;

        public GroupsProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Group> GetAll()
        {
            List<Group> result = new List<Group>();

            try
            {
                _connection.Open();
                var command = new SqlCommand(
                    cmdText: @"
                        SELECT
                            [Groups].[id],
                            [Groups].[name],
                            [Groups].[year],
                            [Groups].[specialty_id],
                            [Specialty].[code],
                            [Specialty].[name]
                        FROM [Groups]
                        LEFT JOIN [Specialty]
                        ON [Specialty].[id] = [Groups].[specialty_id]
                        ",
                    connection: _connection
                    );

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var specialty = new Specialty
                        {
                            Id = reader.GetInt32(3),
                            Code = reader.GetString(4),
                            Name = reader.GetString(5)
                        };

                        var group = new Group
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Year = reader.GetInt32(2),
                            SpecialtyId = reader.GetInt32(3),
                            Specialty = specialty
                        };

                        result.Add(group);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Add(Group group)
        {
            bool result = false;

            try
            {
                _connection.Open();
                var command = new SqlCommand(
                    cmdText: @"
                        INSERT INTO [Groups]
                            ( 
                            [Groups].[name],
                            [Groups].[year],
                            [Groups].[specialty_id]
                            )
                        VALUES
                            (@Name, @Year, @SpecialtyId)
                        ",
                    connection: _connection
                );

                command.Parameters.AddWithValue("@Name", group.Name);
                command.Parameters.AddWithValue("@Year", group.Year);
                command.Parameters.AddWithValue("@SpecialtyId", group.SpecialtyId);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Update(int id, Group newValue)
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
                            [year] = @Year
                            [specialty_id] = @SpecialtyId
                        WHERE 
                            [id] = @Id
                        ",
                    connection: _connection
                );
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Year", newValue.Year);
                command.Parameters.AddWithValue("@SpecialtyId", newValue.SpecialtyId);

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
                        DELETE FROM [Groups]
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
