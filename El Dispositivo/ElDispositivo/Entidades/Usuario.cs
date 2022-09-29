using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private ESistemaOperativo sisOperativo;
        private string nomUsuario;

        public Usuario(ESistemaOperativo sisOperativo, string nomUsuario)
        {
            this.sisOperativo = sisOperativo;
            this.nomUsuario = nomUsuario;
        }

        public ESistemaOperativo SisOperativo { get => sisOperativo; }
        public string NomUsuario { get => nomUsuario; }
    }
}
