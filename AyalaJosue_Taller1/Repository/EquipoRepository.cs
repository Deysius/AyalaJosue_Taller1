using AyalaJosue_Taller1.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AyalaJosue_Taller1.NewFolder
{
    public class EquipoRepository
    {
        private static List<Equipo> equipos;
        static EquipoRepository()
        {
            if (equipos == null)
            {
                equipos = new List<Equipo>();

                Equipo ldu = new Equipo
                {
                    Id = 1,
                    Nombre = "Liga de Quito",
                    PartidosJugados = 10,
                    PartidosGanados = 10,
                    PartidosEmpatados = 10,
                    PartidosPerdidos = 10,
                    Descripcion= "Liga de Quito, originario de la ciudad de Quito. Fue fundado el 11 de enero de 1930",
                    Logo="/Imagenes/liga de quito.jpeg",
                };

                Equipo barcelona = new Equipo
                {
                    Id = 2,
                    Nombre = "Barcelona",
                    PartidosJugados = 10,
                    PartidosGanados = 7,
                    PartidosEmpatados = 2,
                    PartidosPerdidos = 1,
                    Descripcion = "El Barcelona Sporting Club, originario de la ciudad de Guayaquil, fundado el 1 de mayo de 1925",
                    Logo = "/Imagenes/barpng2.png",
                };

                Equipo emelec = new Equipo
                {
                    Id = 3,
                    Nombre = "Emelec",
                    PartidosJugados = 10,
                    PartidosGanados = 5,
                    PartidosEmpatados = 3,
                    PartidosPerdidos = 2,
                    Descripcion = "El Club Sport Emelec, originario de la ciudad de Guayaquil fue fundado el 28 de abril de 1929 ",
                    Logo = "/Imagenes/emelec.png",

                };

                Equipo independiente = new Equipo
                {
                    Id = 4,
                    Nombre = "Independiente del Valle",
                    PartidosJugados = 10,
                    PartidosGanados = 8,
                    PartidosEmpatados = 1,
                    PartidosPerdidos = 1,
                    Descripcion= "El Club Deportivo Independiente del Valle,  es un club deportivo ecuatoriano de la ciudad de Sangolquí, fundado el 1 de marzo de 1958 ",
                    Logo = "/Imagenes/independiente.png",
                };

                equipos.Add(ldu);
                equipos.Add(barcelona);
                equipos.Add(emelec);
                equipos.Add(independiente);
            }
        }

        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            return equipos;
        }

        public Equipo DevuelveEquiposPorID(int id)
        {
            return equipos.FirstOrDefault(e => e.Id == id);
        }

        public bool ActializarEquipo(int id, Equipo equipoEditado)
        {
            var equipo = equipos.FirstOrDefault(e => e.Id == id);
            if (equipo != null)
            {
                equipo.Nombre = equipoEditado.Nombre;
                equipo.PartidosJugados = equipoEditado.PartidosJugados;
                equipo.PartidosGanados = equipoEditado.PartidosGanados;
                equipo.PartidosEmpatados = equipoEditado.PartidosEmpatados;
                equipo.PartidosPerdidos = equipoEditado.PartidosPerdidos;
                return true;
            }
            return false;
        }
    }
}