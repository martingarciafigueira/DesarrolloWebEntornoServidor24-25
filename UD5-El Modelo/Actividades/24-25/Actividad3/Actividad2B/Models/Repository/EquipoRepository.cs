
using Dapper;
using System.Data;

namespace Actividad3.Models.Repository
{
    public class EquipoRepository : IEquipoRepository
    {
        private readonly Conexion _conexion;

        public EquipoRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public void CreateEquipo(Equipo equipo)
        {
            var query = "INSERT INTO Equipos (Codigo, Nombre, Estadio) VALUES (@codigo, @nombre, @estadio)";

            var parameters = new DynamicParameters();
            parameters.Add("codigo", equipo.Codigo, DbType.String);
            parameters.Add("nombre", equipo.Nombre, DbType.String);
            parameters.Add("estadio", equipo.Estadio, DbType.String);

            using (var connection = _conexion.ObtenerConexion())
            {
                connection.Execute(query, parameters);
            }
        }

        public void DeleteEquipo(Equipo equipo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Equipo> GetEquipos()
        {
            var query = "SELECT * FROM Equipos";
            using (var connection = _conexion.ObtenerConexion())
            {
                var equipos = connection.Query<Equipo>(query);
                return equipos;
            }
        }

        public void UpdateEquipo(Equipo equipo)
        {
            throw new NotImplementedException();
        }
    }
}
