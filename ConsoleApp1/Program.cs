using ConsoleApp1;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;
using System.Xml;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());
            List<Empresa> list = new List<Empresa>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionario #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Empresa(id, nome, salario));
            }
            Console.WriteLine();
            Console.Write("Entre com o id do funcionario que deseja dar aumento: ");
            int procurarFuncionario = int.Parse(Console.ReadLine());
            Empresa emp = list.Find(x => x.Id == procurarFuncionario);

            if(emp != null)
            {
                Console.Write("Entre com o valor em porcetagem do aumento do funcionario: ");
                double porcetagem = double.Parse(Console.ReadLine());
                emp.IncrementaSalario(porcetagem);
            }
            else
            {
                Console.Write("Esse funcionario não existe!");
            }
            Console.WriteLine();
            Console.Write("Funcionarios atualzados: ");
            foreach(Empresa obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
} 