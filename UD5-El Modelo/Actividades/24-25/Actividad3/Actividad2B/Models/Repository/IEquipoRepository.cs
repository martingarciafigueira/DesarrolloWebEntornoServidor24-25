namespace Actividad3.Models.Repository
{
    public interface IEquipoRepository
    {
        IEnumerable<Equipo> GetEquipos();
        void CreateEquipo(Equipo equipo);
        void UpdateEquipo(Equipo equipo);
        void DeleteEquipo(Equipo equipo);
    }
}
