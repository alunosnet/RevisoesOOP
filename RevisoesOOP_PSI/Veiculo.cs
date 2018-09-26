using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisoesOOP_PSI
{
    class Veiculo
    {
        public string matricula;
        public DateTime entrada;
        public string marca;
        public string modelo;

        public Veiculo() { }
        public Veiculo(string matricula,string marca,string modelo)
        {
            entrada = DateTime.Now;
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
        }
        
        public virtual void Ler()
        {
            entrada = DateTime.Now;
            Console.Write("Matrícula: ");
            this.matricula = Console.ReadLine();
            Console.Write("Marca: ");
            this.marca = Console.ReadLine();
            Console.Write("Modelo: ");
            this.modelo = Console.ReadLine();
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("Matrícula: {0}", this.matricula);
            Console.WriteLine("Marca: {0}", this.marca);
            Console.WriteLine("Modelo: {0}", this.modelo);
            Console.WriteLine("Entrou às {0}", this.entrada);
        }
        public override string ToString()
        {
            return this.matricula;
        }
        public override bool Equals(object obj)
        {
            var test = obj as Veiculo;
            if (test == null) return false;

            return this.matricula==test.matricula;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
