using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisoesOOP_PSI
{
    class Passageiros : Veiculo
    {
        public int lotacao;
        public int nr_ocupantes;

        public Passageiros() { }
        public Passageiros(string matricula, string marca, string modelo,
            int lotacao, int nr_ocupantes)
            : base(matricula, marca, modelo)
        {
            this.lotacao = lotacao;
            this.nr_ocupantes = nr_ocupantes;
        }
        public override void Ler()
        {
            base.Ler();
            Console.Write("Lotação: ");
            lotacao = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr ocupantes: ");
            nr_ocupantes = Convert.ToInt32(Console.ReadLine());

        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Lotação: {0}", this.lotacao);
            Console.WriteLine("Nr ocupantes: {0}", this.nr_ocupantes);
        }
    }
}
