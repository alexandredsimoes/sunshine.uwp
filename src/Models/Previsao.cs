using System;
using Prism.Mvvm;

namespace Sunshine.UWP.Models
{
    public class Previsao : BindableBase
    {
        public DateTime Data { get; set; }
        public double Maxima { get; set; }
        public double Minima { get; set; }
        public string Status { get; set; }
        public string Descricao { get; set; }
        public double Pressao { get; set; }
        public double VelocidadeVento { get; set; }
        public int Humidade { get; set; }
        public int PosicaoVento { get; set; }
    }
}