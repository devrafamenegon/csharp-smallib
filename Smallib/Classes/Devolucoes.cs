using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallib
{
    public class Devolucao_Livro
    {
        public int pk_id_emprestimo { get; set; }
        public int fk_id_leitor_emprestimo { get; set; }
        public int fk_id_livro_emprestimo { get; set; }
        public string nome_leitor { get; set; }
        public string titulo_livro { get; set; }
        public DateTime dt_emprestimo { get; set; }
        public DateTime dt_dev_prev_emprestimo { get; set; }
    }
}
