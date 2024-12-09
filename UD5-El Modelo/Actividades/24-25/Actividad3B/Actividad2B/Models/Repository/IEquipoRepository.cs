namespace Actividad3.Models.Repository
{
    public interface IEquipoRepository
    {
        IEnumerable<Equipo> GetEquipos();
        Equipo GetEquipoById(string codigo);
        void CreateEquipo(Equipo equipo);
        void UpdateEquipo(Equipo equipo);
        void DeleteEquipo(Equipo equipo);
    }
}
