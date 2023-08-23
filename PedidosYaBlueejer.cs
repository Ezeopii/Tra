using System;

// Clase para el repartidor de drones
public class RepartidorDrone
{
    public void EntregarPedido(string pedido)
    {
        Console.WriteLine($"Entregando pedido con drone: {pedido}");
    }
}

// Singleton para gestionar los repartidores de drones
public class GestorRepartidores
{
    private static GestorRepartidores _instancia;
    private RepartidorDrone _repartidorDrone;

    private GestorRepartidores()
    {
        // Inicialización del repartidor de drones
        _repartidorDrone = new RepartidorDrone();
    }

    public static GestorRepartidores Instancia
    {
        get
        {
            if (_instancia == null)
            {
                _instancia = new GestorRepartidores();
            }
            return _instancia;
        }
    }

    public RepartidorDrone ObtenerRepartidorDrone()
    {
        return _repartidorDrone;
    }
}

// Uso
class Program
{
    static void Main(string[] args)
    {
        // Usar el gestor de repartidores para obtener el repartidor de drones
        var gestorRepartidores = GestorRepartidores.Instancia;
        var repartidorDrone = gestorRepartidores.ObtenerRepartidorDrone();

        repartidorDrone.EntregarPedido("Pedido #123");
    }
}
