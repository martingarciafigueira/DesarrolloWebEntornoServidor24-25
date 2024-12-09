namespace Actividad3.Models.Repository
{
    public interface IFutbolistaRepository
    {
        IEnumerable<Futbolista> GetFutbolistas();
        Futbolista GetFutbolistaById(string codigo);
        void CreateFutbolista(Futbolista equipo);
        void UpdateFutbolista(Futbolista equipo);
        void DeleteFutbolista(Futbolista equipo);
    }
}
