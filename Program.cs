using System;

namespace Atividade {
    class Program {
        static void Main(string[] args) {  
            float valor_pagar;

            Console.WriteLine("Digite um nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Digite um Endereço: ");
            string address = Console.ReadLine();

            Console.WriteLine("Pessoa física (f) ou jurídica (j)? ");
            string type = Console.ReadLine();

            if(type == "f") {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = name;
                pf.endereco = address;
                Console.WriteLine("Digite um CPF: ");
                pf.cpf = Console.ReadLine();

                Console.WriteLine("Digite um RG: ");
                pf.rg = Console.ReadLine();

                Console.WriteLine("Digite um valor de compra: ");
                valor_pagar = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(valor_pagar);

                Console.WriteLine("------ Pessoa Física ------");
                Console.WriteLine($"Nome ..........: {pf.nome}");
                Console.WriteLine($"Endereço ......: {pf.endereco}");
                Console.WriteLine($"CPF ...........: {pf.cpf}");
                Console.WriteLine($"RG ............: {pf.rg}");
                Console.WriteLine($"Valor da compra: {pf.valor:C}");
                Console.WriteLine($"Imposto .......: {pf.valor_imposto:C}");
                Console.WriteLine($"Total .........: {pf.total:C}");
            }
            else if(type == "j") {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = name;
                pj.endereco = address;
                Console.WriteLine("Digite um CNPJ: ");
                pj.cnpj = Console.ReadLine();

                Console.WriteLine("Digite um IE: ");
                pj.ie = Console.ReadLine();

                Console.WriteLine("Digite um valor de compra: ");
                valor_pagar = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(valor_pagar);

                Console.WriteLine("------ Pessoa Física ------");
                Console.WriteLine($"Nome ..........: {pj.nome}");
                Console.WriteLine($"Endereço ......: {pj.endereco}");
                Console.WriteLine($"CNPJ ...........: {pj.cnpj}");
                Console.WriteLine($"IE ............: {pj.ie}");
                Console.WriteLine($"Valor da compra: {pj.valor:C}");
                Console.WriteLine($"Imposto .......: {pj.valor_imposto:C}");
                Console.WriteLine($"Total .........: {pj.total:C}");
            }
        }
    }
}