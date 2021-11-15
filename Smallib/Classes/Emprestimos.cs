using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallib
{
    public class Emprestimo_Livro
    {
        public int pk_id_emprestimo { get; set; }
        public string nome_leitor { get; set; }
        public string titulo_livro { get; set; }
        public DateTime dt_emprestimo { get; set; }
        public DateTime dt_dev_prev_emprestimo { get; set; }
        public DateTime dt_devolucao_emprestimo { get; set; }
        public int status_emprestimo { get; set; }
    }
}
