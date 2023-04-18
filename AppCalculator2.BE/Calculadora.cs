using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculator2.BE
{
    public class Calculadora
    {
        public decimal Resultado { get; set; }
        public decimal Operador1 { get; set; }

        private string Ultimaoperacion = "";
        public string Operacion(string aOperacion, string aOperador1)
        {
            Operador1 = System.Convert.ToDecimal(aOperador1);
            if (aOperacion != "=") 
            {
                Ultimaoperacion = aOperacion;
            }
            string Respuesta = "";
            if (Resultado == 0)
            {
                Resultado = Operador1;
            }
            else
            {
                switch (aOperacion)
                {
                    case "+":
                        {
                            Resultado = Resultado + Operador1;
                            break;
                        }
                    case "-":
                        {
                            Resultado = Resultado - Operador1;
                            break;
                        }
                    case "*":
                        {
                            Resultado = Resultado * Operador1;
                            break;
                        }
                    case "/":

                        Resultado = Resultado / Operador1;
                        break;
                    case "=":
                        {
                            switch (Ultimaoperacion)
                            {
                                case "+":
                                    {
                                        Resultado = Resultado + Operador1;
                                        break;
                                    }
                                case "-":
                                    {
                                        Resultado = Resultado - Operador1;
                                        break;
                                    }
                                case "*":
                                    {
                                        Resultado = Resultado * Operador1;
                                        break;
                                    }
                                case "/":

                                    Resultado = Resultado / Operador1;
                                    break;
                            }
                            break;
                        }
                    default:
                        Respuesta = "Operación incorrecta";
                        break;
                }
            }
            return Respuesta;
        }
    }
}
