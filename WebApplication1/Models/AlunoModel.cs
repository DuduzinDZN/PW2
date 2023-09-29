using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AlunoModel
    {
        public String Nome { get; set; }
        public string Curso { get; set; }
        public DateTime Matricula { get; set; }
        public int Faltas { get; set; }

        public AlunoModel()
        {
            Nome = "Nicolas";
            Curso = "DS1";
            Matricula = new DateTime(2023, 1, 1);
            Faltas = 10;
        }

        public static AlunoModel CriarAluno()
        {
            var aluno = new AlunoModel();
            aluno.Nome = "Emerson";

            return aluno;

        }
        public static List<AlunoModel> CriarLista()
        {
            var lista = new List<AlunoModel>();
            lista.Add(new AlunoModel());
            lista.Add(AlunoModel.CriarAluno());

            return lista;
        }
        
 

    }

}
