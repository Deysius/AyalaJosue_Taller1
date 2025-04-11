using AyalaJosue_Taller1.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AyalaJosue_Taller1.NewFolder
{
    public class EquipoRepository
        //Holaa
    {
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Liga de quito",
                PartidosJugados = 10,
                PartidosGanamos = 10,
                PartidosEmpatadaso = 10,
                PartidosPerdidos = 10,

            };
            Equipo barcelona = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanamos = 7,
                PartidosEmpatadaso = 2,
                PartidosPerdidos = 1,

            };
            equipos.Add(ldu);
            equipos.Add(barcelona);
            return equipos;
        }
        public Equipo DevuelveEquiposPorID(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.First(item=> item.Id == Id);
            return equipo;
        }
        public bool ActializarEquipo(int id, Equipo equipo)
        {
            return true;

        }
    }
}
