namespace logica
{
    public class Principal
    {
        List<Envio> Envios=new List<Envio>();
        List<Destinatario> Destinatarios=new List<Destinatario>();
        public int RegistrarEnvio(int DniDestinatario, DateTime FechaEstimadaEntrega, string Descripcion)
        {
            foreach (var item in Destinatarios)
            {
                if(item.dni==DniDestinatario & item.TelefonoDeContacto!=null)
                {
                    Envio envio=new Envio();
                    Envio nuevoenvio=new Envio();
                    Random Aleatorio=new Random();
                    Console.WriteLine(Aleatorio.Next(Aleatorio.Next()));
                    nuevoenvio.NumeroAleatorioEnvio = Aleatorio;
                    nuevoenvio.Destinatario = item;
                    nuevoenvio.Estado = 1;
                    nuevoenvio.Repartidor = envio.Repartidor;
                    nuevoenvio.FechaEstimadaEntrega=FechaEstimadaEntrega;
                    return 201;
                }
                return 400;
        }
            return 0;

    }
        public bool ActualizarEnvio(Random numeroAleatorio, int EstadoActual)
        {
            foreach (var item in Envios)
            {
                if(item.Estado==EstadoActual & item.Estado=1)
                {
                    item.Repartidor.Comision = item.Valor * item.Repartidor.Comision;
                    item.FechaEstimadaEntrega = item.FechaEntrega;
                    return true;
                }
                return false;
        }
            
}
    }
}
