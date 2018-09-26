using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisoesOOP_PSI
{
    class Mercadorias : Veiculo
    {
        public double pesoMaximo;
        public string tipocarga;

        public Mercadorias() { }
        public Mercadorias(string matricula,string marca,string modelo,
            double peso,string tipocarga)
            : base(matricula,marca,modelo)
        {
            this.pesoMaximo = peso;
            this.tipocarga = tipocarga;
        }
        public override void Ler()
        {
            base.Ler();
            Console.Write("Peso máximo: ");
            pesoMaximo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tipo de carga: ");
            tipocarga = Console.ReadLine();

        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Peso máximo: {0}", this.pesoMaximo);
            Console.WriteLine("Tipo de carga: {0}", this.tipocarga);
        }
    }
}
