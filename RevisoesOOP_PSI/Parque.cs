using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisoesOOP_PSI
{
    class Parque
    {
        const int LOTACAO = 300;
        List<Veiculo> lugares;

        public Parque()
        {
            lugares = new List<Veiculo>();
        }
        ~Parque()
        {
            Console.WriteLine("Obrigado por utilizar o nosso programa");
            Console.ReadKey();
        }
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("1. Entrada");
                Console.WriteLine("2. Saída");
                Console.WriteLine("3. Estado");
                Console.WriteLine("4. Procurar");
                Console.WriteLine("5. Listar");
                Console.WriteLine("6. Terminar");
                Console.Write("Opção: ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Entrada();
                        break;
                    case 2:
                        Saida();
                        break;
                    case 3:
                        Estado();
                        break;
                    case 4:
                        Procurar();
                        break;
                    case 5:
                        Listar();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Essa opção não existe");
                        break;
                }
            }
        }
        public void Entrada()
        {
            if (lugares.Count == LOTACAO)
            {
                Console.WriteLine("Parque está cheio.");
                return;
            }
            Veiculo novo = null;
            Console.WriteLine("Tipo de veículo: (v,m,p)");
            char op = Convert.ToChar(Console.ReadLine());
            if (op == 'v' || op == 'V')
                novo = new Veiculo();
            if (op == 'm' || op == 'M')
                novo = new Mercadorias();
            if (op == 'p' || op == 'P')
                novo = new Passageiros();
            if (novo == null)
            {
                Console.WriteLine("Não pode entrar com esse tipo de veículo");
                return;
            }
            novo.Ler();
            //TODO: testar a matrícula
            lugares.Add(novo);
            LugaresVagos();

        }

        private void LugaresVagos()
        {
            Console.WriteLine("Tem {0} lugar livres", LOTACAO - lugares.Count);
        }

        public void Saida()
        {
            Console.WriteLine("Matrícula: ");
            string matricula = Console.ReadLine();
            Veiculo sair = null;
            foreach (Veiculo v in lugares)
                if (v.matricula == matricula)
                    sair = v;

            if (sair != null)
                lugares.Remove(sair);
            else
                Console.WriteLine("Matrícula não encontrada");
            LugaresVagos();
        }
        public void Procurar()
        {

        }
        public void Listar()
        {

        }
        /// <summary>
        /// Mostra o nr de lugares ocupados, lugares livres
        /// Nr de veículos por tipo
        /// </summary>
        public void Estado()
        {
            LugaresVagos();
            Console.WriteLine("Lugares ocupados: {0}", lugares.Count);
            int contav = 0, contam = 0, contap = 0;
            for (int i = 0; i < lugares.Count; i++)
            {
                if (lugares[i] is Veiculo)
                    contav++;
            }
        }
    }
}
