using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Calculator
    {
        private List<string> historico;
        private string data;

        public Calculator(string data)
        {
            historico = new List<string>();
            this.data = data;
        }

        public int Somar(int num1, int num2)
        {
            int res = num1 + num2;
            historico.Insert(0, $"Val: {res} Data: {data}");
            return res;
        }

        public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            historico.Insert(0, $"Val: {res} Data: {data}");
            return res;
        }

        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            historico.Insert(0, $"Val: {res} Data: {data}");
            return res;
        }

        public int Dividir(int num1, int num2)
        {
            int res = num1 / num2;
            historico.Insert(0, $"Val: {res} Data: {data}");
            return res;
        }

        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }

    }
}
