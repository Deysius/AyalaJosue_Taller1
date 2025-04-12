﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AyalaJosue_Taller1.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        [MaxLength(100)]
        [DisplayName("Nombre del equipo")]
        public string Nombre { get; set; }
        [Range(0, 100)]
        public int PartidosJugados { get; set; }
        [Range(0, 100)]
        public int PartidosGanamos { get; set; }
        [Range(0, 100)]
        public int PartidosEmpatadaso { get; set; }
        [Range(0, 100)]
        public int PartidosPerdidos { get; set; }
    }
}
