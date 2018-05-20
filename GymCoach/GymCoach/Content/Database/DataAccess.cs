using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using Database;

namespace GymCoach.Content.Database
{
    public class DataAccess
    {
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=|DataDirectory|\GymDB.mdf;Integrated Security=true;MultipleActiveResultSets=True";

        public List<Exercise> getExercises()
        {
            List<Exercise> exercises = new List<Exercise>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Exercises;";
            SqlCommand command = new SqlCommand(query);

            command.Connection = connection;
            command.CommandType = CommandType.Text;

            try
            {
                command.Connection.Open();
                command.Prepare();
                SqlDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    Exercise exercise = new Exercise();
                    exercise.setExerciseID(reader.GetInt32(reader.GetOrdinal("ExerciseID")));
                    exercise.setExerciseName(reader.GetString(reader.GetOrdinal("ExerciseName")));
                    exercise.setDescription(reader.GetString(reader.GetOrdinal("Description")));
                    exercise.setNote(reader.GetString(reader.GetOrdinal("Note")));
                    exercise.setEquipmentType(reader.GetString(reader.GetOrdinal("EquipmentType")));
                    exercise.setPrimaryMuscle(reader.GetString(reader.GetOrdinal("PrimaryMuscle")));
                    exercise.setHN(reader.GetInt32(reader.GetOrdinal("Heuristic")));
                    exercise.setGN(reader.GetInt32(reader.GetOrdinal("Danger")));
                    exercises.Add(exercise);
                    count++;
                }
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
            }
            command.Connection.Close();
            command.Dispose();
            connection.Dispose();
            return exercises;
        }
    }
}