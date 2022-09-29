using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;
        public AppMusical(string nombre, ESistemaOperativo sistemaOperativo, int tamanioInicial)
            : base(nombre, sistemaOperativo, tamanioInicial)
        {
        }
        public AppMusical(string nombre, ESistemaOperativo sistemaOperativo, int tamanioInicial, List<string> listaCanciones)
            : this(nombre, sistemaOperativo, tamanioInicial)
        {
            this.listaCanciones = listaCanciones;
        }
        public override int Tamanio
        {
            get
            {
                if (listaCanciones is not null)
                {
                    foreach (string cancion in listaCanciones)
                    {
                        tamanioMb += 2;
                    }
                }
                return tamanioMb;
            }
        }
        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacionApp());
            sb.AppendLine("Lista de canciones:");
            if (listaCanciones is not null)
            {
                foreach (string canciones in listaCanciones)
                {
                    sb.AppendLine(canciones);
                }
            }
            else sb.AppendLine("No se encontraron canciones");
            sb.AppendLine("---------------------------");
            return sb.ToString();
        }
    }
}
