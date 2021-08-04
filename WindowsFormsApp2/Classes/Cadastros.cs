using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallib
{
    public class Cadastro_Usuario
    {
        public int pk_id_usuario { get; set; }
        public string nome_usuario { get; set; }
        public string login_usuario { get; set; }
        public string senha_usuario { get; set; }
    }

    public class Cadastro_Genero
    {
        public int pk_id_genero { get; set; }
        public string nome_genero { get; set; }
    }

    public class Cadastro_Idioma
    {
        public int pk_id_idioma { get; set; }
        public string nome_idioma { get; set; }
    }
}
