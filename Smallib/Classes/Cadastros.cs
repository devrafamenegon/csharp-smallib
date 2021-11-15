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

    public class Cadastro_Nacionalidade
    {
        public int pk_id_nacionalidade { get; set; }
        public string nome_nacionalidade { get; set; }
    }

    public class Cadastro_Curso
    {
        public int pk_id_curso { get; set; }
        public string nome_curso{ get; set; }
    }

    public class Cadastro_Cidade
    {
        public int pk_id_cidade { get; set; }
        public string nome_cidade { get; set; }
        public string estado_cidade { get; set; }
    }

    public class Cadastro_Autor
    {
        public int pk_id_autor { get; set; }
        public string nacionalidade_autor { get; set; }
        public string nome_autor { get; set; }      
    }

    public class Cadastro_Editora
    {
        public int pk_id_editora { get; set; }
        public string nome_cidade { get; set; }
        public string estado_cidade { get; set; }
        public string nome_editora { get; set; }
        public string email_editora { get; set; }
        public string tel_editora { get; set; }
        public string site_editora { get; set; }

    }

    public class Cadastro_Livro
    {
        public int pk_id_livro { get; set; }
        public string titulo_livro { get; set; }
        public string tombo_livro { get; set; }
        public string editora_livro { get; set; }
        public string autor_livro { get; set; }
        public string genero_livro { get; set; }
        public string idioma_livro { get; set; }
        public string ultemprest_livro { get; set; }
        public string ultleitor_livro { get; set; }
        public int status_livro { get; set; }
    }

    public class Cadastro_Tipo_Leitor
    {
        public int pk_id_tipo { get; set; }
        public string nome_tipo { get; set; }
    }

    public class Cadastro_Leitor
    {
        public int pk_id_leitor { get; set; }
        public string nome_leitor { get; set; }
        public string email_leitor { get; set; }
        public string tel_cel_leitor { get; set; }
        public string rg_leitor { get; set; }
        public DateTime dtnasc_leitor { get; set; }
        public DateTime dtcad_leitor { get; set; }
        public string cidade_leitor { get; set; }
        public string estado_leitor { get; set; }
        public string tipo_leitor { get; set; }
        public string curso_leitor { get; set; }
        public string classe_leitor { get; set; }
        public string status_leitor { get; set; }
    }
}
