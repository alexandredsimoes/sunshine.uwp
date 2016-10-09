using System;
using System.Collections;
using System.Collections.Generic;
using Sunshine.UWP.Models;

namespace Sunshine.UWP.ViewModels.Design
{
    public class MainPageDesignViewModel
    {
        public MainPageDesignViewModel()
        {
            Previsoes = new List<Previsao>()
            {
                new Previsao()
                {
                    Data = DateTime.Now,
                    Maxima = 30,
                    Minima = 27,
                    Status = "sol"
                },
                new Previsao()
                {
                    Data = DateTime.Now,
                    Maxima = 20,
                    Minima = 17,
                    Status = "neve"
                },
                new Previsao()
                {
                    Data = DateTime.Now,
                    Maxima = 10,
                    Minima = 7,
                    Status = "nuvem"
                }
            };
        }

        public IList<Previsao> Previsoes { get; set; }
    }
}