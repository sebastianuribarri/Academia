using Entities;
using Domain.Validations;
using System.Data.SqlClient;

namespace Domain.Services
{
    public class PlanService
    {
        private readonly string _connectionString = "Server=localhost;Database=Academia;Trusted_Connection=True;TrustServerCertificate=True";
        private readonly PlanValidation planValidation;

        public PlanService()
        {
            planValidation = new PlanValidation();
        }

        public void Add(Plan plan)
        {
            if (planValidation.isValid(plan))
            {
                using var connection = new SqlConnection(_connectionString);
                connection.Open();

                var query = "INSERT INTO Planes (id_especialidad, desc_plan, activo) VALUES (@id_especialidad, @desc_plan, @activo)";
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_especialidad", plan.id_especialidad);
                command.Parameters.AddWithValue("@desc_plan", plan.desc_plan);
                command.Parameters.AddWithValue("@activo", true);

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int? id)
        {
            if (id == null) return;

            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var query = "UPDATE Planes SET activo = 0 WHERE id_plan = @id";
            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
        }

        public Plan? Get(int? id)
        {
            if (id == null) return null;

            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var query = "SELECT * FROM Planes WHERE id_plan = @id AND activo = 1";
            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Plan
                {
                    id_plan = reader.GetInt32(reader.GetOrdinal("id_plan")),
                    id_especialidad = reader.GetInt32(reader.GetOrdinal("id_especialidad")),
                    desc_plan = reader.GetString(reader.GetOrdinal("desc_plan")),
                    activo = reader.GetBoolean(reader.GetOrdinal("activo"))
                };
            }

            return null;
        }

        public List<PlanDto> GetAll()
        {
            var planDtos = new List<PlanDto>();

            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var query = @"
                SELECT p.id_plan, p.desc_plan, e.desc_especialidad
                FROM Planes p
                INNER JOIN Especialidades e ON p.id_especialidad = e.id_especialidad
                WHERE p.activo = 1";

            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                planDtos.Add(new PlanDto
                {
                    id_plan = reader.GetInt32(reader.GetOrdinal("id_plan")),
                    desc_plan = reader.GetString(reader.GetOrdinal("desc_plan")),
                    desc_especialidad = reader.GetString(reader.GetOrdinal("desc_especialidad"))
                });
            }

            return planDtos;
        }

        public void Update(Plan plan)
        {
            if (planValidation.isValid(plan))
            {
                using var connection = new SqlConnection(_connectionString);
                connection.Open();

                var query = "UPDATE Planes SET id_especialidad = @id_especialidad, desc_plan = @desc_plan WHERE id_plan = @id";
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_especialidad", plan.id_especialidad);
                command.Parameters.AddWithValue("@desc_plan", plan.desc_plan);
                command.Parameters.AddWithValue("@id", plan.id_plan);

                command.ExecuteNonQuery();
            }
        }
    }
}
