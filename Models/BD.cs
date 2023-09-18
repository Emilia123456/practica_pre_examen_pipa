using System.Data.SqlClient;
using Dapper;

public class BD{

    private static string _connectionString = @"Server=localhost; DataBase=GestionAlumnos;Trusted_Connection=True;";

    public static List<Alumnos> ObtenerNombreYApellidoAlumnos(string nombre, string apellido){
        List<Alumnos> ListaNomApellAlumnos = new List<Alumnos>();
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT nombre, apellido FROM Alumnos";
            ListaNomApellAlumnos = db.Query<Alumnos>(sql).ToList();
        }
        return ListaNomApellAlumnos;
    }


}

