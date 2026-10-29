using System;

namespace Kepler_7.Strategy
{
    public enum AccionIA
    {
        Atacar,
        Avanzar,
        Retroceder,
        Cubrirse,
        UsarObjeto
    }
    public class Contexto
    {
        public const int VidaMaxima = 100;
        public const int AlcanceAtaque = 3;
        public const int DistanciaMaxima = 100;

        public int VidaEnemigo { get; private set; }
        public int VidaJugador { get; private set; }
        public int Distancia { get; private set; }
        public bool EnemigoCubierto { get; private set; }
        public int CuracionesEnemigo { get; private set; } = 2;
        public bool PartidaTerminada
        {
            get { return VidaEnemigo <= 0 || VidaJugador <= 0; }
        }
        public Contexto(int vidaEnemigo,int vidaJugador,int distancia)
        {
            if (vidaEnemigo < 1 || vidaEnemigo > VidaMaxima)
                throw new ArgumentOutOfRangeException(nameof(vidaEnemigo));

            if (vidaJugador < 1 || vidaJugador > VidaMaxima)
                throw new ArgumentOutOfRangeException(nameof(vidaJugador));

            if (distancia < 0 || distancia > DistanciaMaxima)
                throw new ArgumentOutOfRangeException(nameof(distancia));

            VidaEnemigo = vidaEnemigo;
            VidaJugador = vidaJugador;
            Distancia = distancia;
        }

        public string JugarTurnoJugador()
        {
            if (PartidaTerminada)
                return "El combate terminó.";

            if (Distancia > AlcanceAtaque)
            {
                Acercar(2);
                return "Jugador -> Avanza 2 unidades hacia el enemigo.";
            }

            int danio = DanarEnemigo(20);
            return "Jugador -> Ataca y causa " + danio + " de daño.";
        }
        public int DanarJugador(int cantidad)
        {
            int aplicado = Math.Min(VidaJugador, Math.Max(0, cantidad));

            VidaJugador -= aplicado;
            return aplicado;
        }
        public int DanarEnemigo(int cantidad)
        {
            int danio = Math.Max(0, cantidad);

            if (EnemigoCubierto)
                danio /= 2;

            int aplicado = Math.Min(VidaEnemigo, danio);

            VidaEnemigo -= aplicado;
            EnemigoCubierto = false;

            return aplicado;
        }

        public void Acercar(int unidades)
        {
            Distancia = Math.Max(0, Distancia - Math.Max(0, unidades));
        }
        public void Alejar(int unidades)
        {
            Distancia = Math.Min(DistanciaMaxima, Distancia + Math.Max(0, unidades));
        }
        public void ActivarCobertura()
        {
            EnemigoCubierto = true;
        }
        public void FinalizarCobertura()
        {
            EnemigoCubierto = false;
        }
        public int CurarEnemigo()
        {
            if (CuracionesEnemigo <= 0 || VidaEnemigo <= 0 || VidaEnemigo >= VidaMaxima)
            {
                return 0;
            }

            int recuperado = Math.Min(25, VidaMaxima - VidaEnemigo);
            VidaEnemigo += recuperado;
            CuracionesEnemigo--;
            return recuperado;
        }
    }
    public interface IEstrategiaIA
    {
        string nombre { get; }
        AccionIA DecidirAccion(Contexto contexto);
    }
    public class IAAgresiva : IEstrategiaIA
    {
        public string nombre => "Agresiva";
        public AccionIA DecidirAccion(Contexto contexto)
        {
            return contexto.Distancia > Contexto.AlcanceAtaque ? AccionIA.Avanzar : AccionIA.Atacar;
        }
    }
    public class IADefensiva : IEstrategiaIA
    {
        public string nombre => "Defensiva";
        public AccionIA DecidirAccion(Contexto contexto)
        {
            if (contexto.VidaEnemigo < 30 && contexto.CuracionesEnemigo > 0)
            {
                return AccionIA.UsarObjeto;
            }
            if (contexto.Distancia > Contexto.AlcanceAtaque)
                return AccionIA.Cubrirse;

            // Con poca vida y sin botiquines, contraataca.
            if (contexto.VidaEnemigo < 30)
                return AccionIA.Atacar;

            return AccionIA.Cubrirse;
        }
    }
    public class IAAleatoria : IEstrategiaIA
    {
        private readonly Random _rng = new Random();

        private static readonly AccionIA[] Acciones =
        {
            AccionIA.Atacar,
            AccionIA.Avanzar,
            AccionIA.Retroceder,
            AccionIA.Cubrirse,
            AccionIA.UsarObjeto
        };
        public string nombre => "Aleatoria";
        public AccionIA DecidirAccion(Contexto contexto)
        {
            return Acciones[_rng.Next(Acciones.Length)];
        }
    }
    public class IACalculadora : IEstrategiaIA
    {
        public string nombre => "Calculadora";
        public AccionIA DecidirAccion(Contexto contexto)
        {
            if (contexto.VidaEnemigo <= 40 && contexto.CuracionesEnemigo > 0)
            {
                return AccionIA.UsarObjeto;
            }

            if (contexto.Distancia > Contexto.AlcanceAtaque)
                return AccionIA.Avanzar;

            if (contexto.VidaJugador <= 15 || contexto.VidaEnemigo >= contexto.VidaJugador)
            {
                return AccionIA.Atacar;
            }

            return AccionIA.Cubrirse;
        }
    }
}