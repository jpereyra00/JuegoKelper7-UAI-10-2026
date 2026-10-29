using System;

namespace Kepler_7.Strategy
{
    public class Enemigo
    {
        public string Nombre { get; }
        public IEstrategiaIA Estrategia { get; set; }
        public Enemigo(string nombre, IEstrategiaIA estrategiaInicial)
        {
            Nombre = nombre;
            Estrategia = estrategiaInicial;
        }
        public string JugarTurno(Contexto contexto)
        {
            if (contexto.PartidaTerminada)
                return "El combate terminó.";

            // La cobertura dura hasta el siguiente turno del enemigo. El jugador ya tuvo oportunidad de atacar antes de este paso.
            contexto.FinalizarCobertura();

            AccionIA accion = Estrategia.DecidirAccion(contexto);
            string resultado;

            switch (accion)
            {
                case AccionIA.Atacar:
                    if (contexto.Distancia <= Contexto.AlcanceAtaque)
                    {
                        int danio = contexto.DanarJugador(15);
                        resultado = "Ataca y causa " + danio + " de daño.";
                    }
                    else
                    {
                        contexto.Acercar(2);
                        resultado = "Está fuera de alcance: avanza 2 unidades.";
                    }
                    break;

                case AccionIA.Avanzar:
                    contexto.Acercar(2);
                    resultado = "Avanza 2 unidades hacia el jugador.";
                    break;

                case AccionIA.Retroceder:
                    contexto.Alejar(2);
                    resultado = "Retrocede 2 unidades.";
                    break;

                case AccionIA.Cubrirse:
                    contexto.ActivarCobertura();
                    resultado = "Se cubre: reduce a la mitad el próximo ataque.";
                    break;

                case AccionIA.UsarObjeto:
                    if (contexto.CuracionesEnemigo > 0 && contexto.VidaEnemigo < Contexto.VidaMaxima)
                    {
                        int recuperado = contexto.CurarEnemigo();
                        resultado = "Usa un botiquín y recupera " + recuperado + " de vida.";
                    }
                    else
                    {
                        contexto.ActivarCobertura();
                        resultado = "No necesita o no tiene botiquines: se cubre.";
                    }
                    break;

                default:
                    throw new InvalidOperationException("Acción de IA desconocida.");
            }

            return Nombre + " [IA " + Estrategia.nombre + "] -> " + resultado;
        }
    }
}