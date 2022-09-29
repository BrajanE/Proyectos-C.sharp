using System.Collections.Generic;
using System.Text;

namespace Entidades
{    
    public abstract class Aplicacion
    {
        protected string nombre;
        protected ESistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        protected Aplicacion(string nombre, ESistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        public ESistemaOperativo SistemaOperativo
        {
            get { return sistemaOperativo; }
        }
        public abstract int Tamanio
        {
            get;
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre App: {nombre}");
            sb.AppendLine($"Sistema Operativo: {SistemaOperativo}");
            sb.AppendLine($"Espacio necesario: {Tamanio}");
            sb.AppendLine("---------------------------");
            return sb.ToString();
        }
        public override string ToString()
        {
            return nombre;
        }

        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            Aplicacion appPesada = null;
            for (int i = 0; i < listaApp.Count; i++)
            {
                for (int j = 1; j < listaApp.Count - 1; j++)
                {
                    if (listaApp[i].Tamanio >= listaApp[j].Tamanio)
                    {
                        appPesada = listaApp[i];
                    }
                    else if (listaApp[i].Tamanio <= listaApp[j].Tamanio)
                    {
                        appPesada = listaApp[j];
                    }
                }
            }
            return appPesada;
        }
        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            foreach (Aplicacion appItem in listaApp)
            {
                if(appItem.nombre == app.nombre)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }
    }
}
