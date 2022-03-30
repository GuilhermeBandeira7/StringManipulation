using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //// TESTANDO OS MÉTODOS substring E indexof
            //string url = "pagina?argumentos";
            //int indiceInterrogacao = url.IndexOf('?'); // the output is 6 witch is =  ?argumentos

            //string argumentos = url.Substring(indiceInterrogacao + 1); // plus 1 the indexOf indiceInterrogacao is 7 witch results in = argumentos

            //Console.WriteLine(argumentos); // argumentos output

            //Console.WriteLine("==============");

            //string palavra = "moedaOrigem=real&moedaDestino=dolar"; // full string
            //string nomeArgumento = "moedaDestino";

            //int indice = palavra.IndexOf(nomeArgumento); // returns the index of "moedaDestino" which is 17.

            //int indiceValor = indice + nomeArgumento.Length;           

            //string valorArgumento = palavra.Substring(indiceValor + 1); // which returns "dolar"

            //Console.WriteLine(valorArgumento);

            //Console.WriteLine("==============");

            //// TESTANDO UMA URL E USANDO ExtratorDeArgumentos E O MÉTODO GetValor PARA OBTER VALORES DOS PARÂMETROS 

            //string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar"; //URL 
            //ExtratorDeArgumentos extratorDeValores = new ExtratorDeArgumentos(urlParametros); // instance of ExtratorDeArgumentos class to manipulate  strings
            //string valor = extratorDeValores.GetValor("moedaOrigem"); // variable valor stores the output of GetValor method that retuns "Real"
            //Console.WriteLine("Valor de moedaOrigem: " + valor);

            //string valor2 = extratorDeValores.GetValor("moedaDestino");
            //Console.WriteLine("Valor de moedaDestino: " + valor2); //variable valor2 stores the output of GetValor method that retuns "Dolar"

            //string testeRemocao = "primeiraParte&parteParaRemover";           
            //int indiceComercial = testeRemocao.IndexOf('&');
            //Console.WriteLine(testeRemocao.Remove(indiceComercial)); // using remove method to cut the string e return only "primeiraParte"           

            //Console.WriteLine("==============");

            //// TESTANDO REPLACE

            //string mensagemOrigem = "PALAVRA";
            //string termoBusca = "ra";
            //termoBusca = termoBusca.Replace('r' , 'R'); // replace needs an old char and a new char as argument. 
            //Console.WriteLine(termoBusca);
            //termoBusca = termoBusca.Replace('a', 'A');
            //Console.WriteLine(termoBusca);

            ////TESTANDO TO UPPER

            //Console.WriteLine(mensagemOrigem.ToUpper());

            //int resultado = mensagemOrigem.IndexOf(termoBusca);
            //Console.WriteLine(resultado);
            //Console.ReadLine();

            URLTestes();
            Console.ReadLine();
        }

        private static void URLTestes()
        {
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.StartsWith("cambio"));
            Console.WriteLine(urlTeste.Contains("bytebank"));

            //Console.WriteLine(indiceByteBank == 0);  //when indexof does not find an index it returns -1. This logic is applied to see if indexof found our index                      
        }
    }
}
