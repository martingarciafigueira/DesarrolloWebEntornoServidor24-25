
using Dapper;
using System.Data;

namespace Actividad3.Models.Repository
{
    public class FutbolistaRepository : IFutbolistaRepository
    {
        private readonly Conexion _conexion;

        public FutbolistaRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public void CreateFutbolista(Futbolista futbolista)
        {
            var query = "INSERT INTO Futbolistas (Codigo, Nombre, Goles, CodigoEquipo) VALUES (@codigo, @nombre, @goles, @codigoequipo)";

            var parameters = new DynamicParameters();
            parameters.Add("codigo", futbolista.codigo, DbType.String);
            parameters.Add("nombre", futbolista.nombre, DbType.String);
            parameters.Add("goles", futbolista.goles, DbType.Int32);
            parameters.Add("codigoequipo", futbolista.codigoEquipo, DbType.String);

            using (var connection = _conexion.ObtenerConexion())
            {
                connection.Execute(query, parameters);
            }
        }

        public void DeleteFutbolista(Futbolista futbolista)
        {
			var query = "DELETE FROM Futbolistas WHERE codigo = @codigo";

			var parameters = new DynamicParameters();
			parameters.Add("codigo", futbolista.codigo, DbType.String);

			using (var connection = _conexion.ObtenerConexion())
			{
				connection.Execute(query, parameters);
			}
		}

        public IEnumerable<Futbolista> GetFutbolistas()
        {
            var query = "SELECT * FROM Futbolistas";
            using (var connection = _conexion.ObtenerConexion())
            {
                var Futbolistas = connection.Query<Futbolista>(query);
                return Futbolistas;
            }
        }

		public Futbolista GetFutbolistaById(string codigo)
		{
			var query = "SELECT * FROM Futbolistas WHERE Codigo = @codigo";

			var parameters = new DynamicParameters();
			parameters.Add("codigo", codigo, DbType.String);

			using (var connection = _conexion.ObtenerConexion())
			{
				var Futbolista = connection.QueryFirst<Futbolista>(query, parameters);
				return Futbolista;
			}
		}

		public void UpdateFutbolista(Futbolista futbolista)
        {
			var query = "UPDATE Futbolistas SET nombre = @nombre, goles = @goles, codigoequipo = @codigoequipo WHERE codigo = @codigo";

			var parameters = new DynamicParameters();
			parameters.Add("codigo", futbolista.codigo, DbType.String);
			parameters.Add("nombre", futbolista.nombre, DbType.String);
			parameters.Add("goles", futbolista.goles, DbType.Int32);
			parameters.Add("codigoequipo", futbolista.codigoEquipo, DbType.String);

			using (var connection = _conexion.ObtenerConexion())
			{
				connection.Execute(query, parameters);
			}
		}
    }
}
