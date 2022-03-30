using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    /// <summary>
    /// Class that returns of arguments of a URL in string format
    /// </summary>
    public class ExtratorDeArgumentos
    {
        private readonly string _argumentos;
        public string URL { get; }
        /// <summary>
        /// Represents a instance of ExtratorDeArgumentos
        /// </summary>
        /// <param name="url"> Represents the value of <see cref="URL"/></param>
        /// <exception cref="ArgumentException"> Exception thrown when the <see cref="URL"/> is empty </exception>
        
        public ExtratorDeArgumentos(string url)
        {

            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("The URL can't be null or empty.", nameof(url));
            }

            URL = url;

            int indiceInterrogacao = url.IndexOf('?'); // after the ? we have the arguments that we want to get the values 
            _argumentos = url.Substring(indiceInterrogacao + 1); // _argumentos receive only the arguments of the url(string after ? sign)

        }
        /// <summary>
        /// Method that returns the values of the parameters
        /// </summary>
        /// <param name="nomeParametro"> Represents the string parameter </param>
        /// <exception cref="IndexOutOfRangeException"></exception>  
        /// <returns></returns>
        public string GetValor(string nomeParametro) // method used to trim a string returning the value of the parameter passed as argument
        {
            nomeParametro = nomeParametro.ToUpper(); // VALOR
            string argumentoEmCaixaAlta = _argumentos.ToUpper();

            string termo = nomeParametro + "="; // moedaDestino= "=" bacause in the url parameters the values comes after the = sign. And we are trying to get the value index
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo); // index of the 'm' the first character of moedaDestino

            string resultado = _argumentos.Substring(indiceTermo + termo.Length); // returns dolar
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1) // -1 used because when the indexof method doesn't find what we are looking for the output is -1. 
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);  

            // Temos o texto "moedaOrigem=real&moedaDestino=XXXX"
            //Buscamos o índice do valor do parâmetro "moedaDestino"
            //Vamos então usar IndexOf("moedaDestino") e, neste índice, somar o tamanho do texto "moedaDestino"

        }
    }
}
