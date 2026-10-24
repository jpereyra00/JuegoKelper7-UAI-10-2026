using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepler_7.Strategy
{
    public class Contexto {
        public int VidaEnemigo { get; }
        public int VidaJugador {  get; }
        public int Distancia { get; }

        public Contexto(int vidaEnemigo, int vidaJugador, int distancia)
        {
            VidaEnemigo = vidaEnemigo;
            VidaJugador = vidaJugador;
            Distancia = distancia;
        }
    }
    public interface IEstrategiaIA { 
        string nombre { get; }
        string DecidirAccion(Contexto c);
    }
    public class IAAgresiva : IEstrategiaIA {
        public string Nombre => "Agresiva";

        public string nombre => throw new NotImplementedException();

        public string DecidirAccion(Contexto c) =>
            c.Distancia > 3 ? "Avanza para acortar distancia y ataca"
                            : "Ataca con todo, cobertura";


    }
    public class IADefensiva : IEstrategiaIA {
        public string nombre => "Defensiva";

        public string DecidirAccion(Contexto c) =>
        
            c.Distancia < 30 ? "Vida baja: se repliega y se cubre"
                           : "Mantiene posición y se bloquea";
                   
    }
    public class IAAleatoria : IEstrategiaIA
    {
        private readonly Random _rng = new Random();
        private static readonly string[] Acciones = { "Ataca", "Se mueve", "Se cubre", "Usa un Objeto" };
        public string nombre => "Aleatoria";

        public string DecidirAccion(Contexto c) => Acciones[_rng.Next(Acciones.Length)];
        }
    public class IACalculadora : IEstrategiaIA
    {
        public string nombre => "Calculadora";

        public string DecidirAccion(Contexto c) =>
            c.VidaJugador < c.VidaEnemigo ? "El jugador esta debil: presiona un ataque"
                                           : "Desventaja: retrocede y espera una apertura";
        
    }
}
