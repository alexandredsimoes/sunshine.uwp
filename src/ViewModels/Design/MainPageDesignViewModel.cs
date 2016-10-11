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
                    Data = DateTime.Now.AddDays(1),
                    Maxima = 20,
                    Minima = 17,
                    Status = "neve"
                },
                new Previsao()
                {
                    Data = DateTime.Now.AddDays(2),
                    Maxima = 10,
                    Minima = 7,
                    Status = "nuvem"
                },
                new Previsao()
                {
                    Data = DateTime.Now.AddDays(3),
                    Maxima = 10,
                    Minima = 7,
                    Status = "chuva"
                },
                new Previsao()
                {
                    Data = DateTime.Now.AddDays(4),
                    Maxima = 10,
                    Minima = 7,
                    Status = "nevoa"
                }
            };
        }

        public IList<Previsao> Previsoes { get; set; }
    }
}