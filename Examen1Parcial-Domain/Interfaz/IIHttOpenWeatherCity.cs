using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaz
{
    public interface IIHttOpenWeatherCity
    {
        Task<OpenWeather> GetWeatherByCityNameAsync(string city);
    }
}
