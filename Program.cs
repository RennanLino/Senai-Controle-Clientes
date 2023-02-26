using Entidades;
namespace ControleClientes {
    class Program {
        public static void Main(String[] args) {

            System.Console.WriteLine("----------Cadastro de Cliente----------");
            float valor;
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            System.Console.Write("Pessoa Física (F) ou Jurídica (J)? ");
            string tipo = Console.ReadLine().ToUpper();
            System.Console.WriteLine();

            while(!tipo.Equals("F") && !tipo.Equals("J")) {
                System.Console.WriteLine("Tipo inválido, tente novamente.");
                System.Console.Write("Pessoa Física (F) ou Jurídica (J)? ");
                tipo = Console.ReadLine().ToUpper();
            }

            if (tipo.Equals("F")) {
                System.Console.WriteLine("----------Pessoa Física----------");
                PessoaFisica pf = new PessoaFisica();
                pf.nome = nome;
                pf.endereco = endereco;
                
                System.Console.Write("CPF: ");
                pf.cpf = Console.ReadLine();
                System.Console.Write("RG: ");
                pf.rg = Console.ReadLine();
                System.Console.Write("Valor da compra: ");
                valor = float.Parse(Console.ReadLine());
                pf.pagarImposto(valor);
                
                System.Console.WriteLine("----------Pessoa Física----------");
                System.Console.WriteLine("Nome ..........: " + pf.nome);
                System.Console.WriteLine("Endereço ......: " + pf.endereco);
                System.Console.WriteLine("CPF ...........: " + pf.cpf);
                System.Console.WriteLine("RG ............: " + pf.rg);
                System.Console.WriteLine("Valor de Compra: " + pf.valor.ToString("C"));
                System.Console.WriteLine("Imposto .......: " + pf.valorImposto.ToString("C"));
                System.Console.WriteLine("Total a pagar .: " + pf.total.ToString("C"));

            } else {
                
                System.Console.WriteLine("----------Pessoa Jurídica----------");
                PessoaJuridica pj = new PessoaJuridica();
                pj.nome = nome;
                pj.endereco = endereco;

                System.Console.Write("CNPJ: ");
                pj.cnpj = Console.ReadLine();
                System.Console.Write("IE: ");
                pj.ie = Console.ReadLine();
                System.Console.Write("Valor da compra: ");
                valor = float.Parse(Console.ReadLine());
                pj.pagarImposto(valor);

                System.Console.WriteLine("----------Pessoa Física----------");
                System.Console.WriteLine("Nome ..........: " + pj.nome);
                System.Console.WriteLine("Endereço ......: " + pj.endereco);
                System.Console.WriteLine("CNPJ ..........: " + pj.cnpj);
                System.Console.WriteLine("IE ............: " + pj.ie);
                System.Console.WriteLine("Valor de Compra: " + pj.valor.ToString("C"));
                System.Console.WriteLine("Imposto .......: " + pj.valorImposto.ToString("C"));
                System.Console.WriteLine("Total a pagar .: " + pj.total.ToString("C"));
            }
        }
    }
}
