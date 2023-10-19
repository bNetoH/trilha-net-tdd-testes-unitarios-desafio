using System.Reflection;
using TDD_TestesUnitarios.Desavio.Console.Models;

namespace TDD_TestesUnitarios.Desavio.Console.Services
{
    public class Operacoes
    {
        private List<Calculadora> historico = new List<Calculadora>();

        public int Somar(int valor1, int valor2) 
        {
            var resultado = valor1 + valor2;
            
            AdicionarHistorico(new Calculadora
            {
                Indice = historico.Count(),
                Operacao =  MethodBase.GetCurrentMethod().Name,
                Valor1 = valor1,
                Valor2 = valor2,
                Resultado = resultado
            });

            return resultado;
        }

        public int Subtrair(int valor1, int valor2) 
        {
            var resultado =  valor1 - valor2;
            AdicionarHistorico(new Calculadora
            {
                Indice = historico.Count(),
                Operacao =  MethodBase.GetCurrentMethod().Name,
                Valor1 = valor1,
                Valor2 = valor2,
                Resultado = resultado
            });

            return resultado;
        }

        public int Multiplicar(int valor1, int valor2) 
        {
            var resultado =  valor1 * valor2;

            AdicionarHistorico(new Calculadora
            {
                Indice = historico.Count(),
                Operacao =  MethodBase.GetCurrentMethod().Name,
                Valor1 = valor1,
                Valor2 = valor2,
                Resultado = resultado
            });

            return resultado;

        }


        public int Dividir(int valor1, int valor2) 
        {
            if(valor2 == 0) CannotBeDivideBy0(valor1);

            var resultado =  valor1 / valor2;
            AdicionarHistorico(new Calculadora
            {
                Indice = historico.Count(),
                Operacao =  MethodBase.GetCurrentMethod().Name,
                Valor1 = valor1,
                Valor2 = valor2,
                Resultado = resultado
            });

            return resultado;
        }

        private Exception CannotBeDivideBy0(int valor1)
        {
            throw new InvalidOperationException($"Impossível divisão de {valor1} por 0");
        }

        public void AdicionarHistorico(Calculadora operacao)
        {
            historico.Insert(0, operacao);
        }

        public List<Calculadora> RetornarHistorico()
        {            
            return historico;
        }
    }
}