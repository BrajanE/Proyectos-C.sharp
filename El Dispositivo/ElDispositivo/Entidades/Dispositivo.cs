using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public enum ESistemaOperativo
    {
        ANDROID, IOS
    }
    public static class Dispositivo
    {
        static List<Aplicacion> appsInstaladas;
        static ESistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            appsInstaladas = new List<Aplicacion>();
            sistemaOperativo = ESistemaOperativo.ANDROID;
        }
        public static bool InstalarApp(Aplicacion app)
        {
            if(sistemaOperativo == app.SistemaOperativo)
            {
                 return appsInstaladas + app;              
            }
            return false;
        }
        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"S.O. del Sistema: {sistemaOperativo}\n");
            foreach (Aplicacion app in appsInstaladas)
            {
                sb.AppendLine(app.ObtenerInformacionApp());
            }
            return sb.ToString();
        }

    }
}
