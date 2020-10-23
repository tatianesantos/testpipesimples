using System;
using Xunit;
using RestSharp;

namespace XUnitTestProject1
{
    public class PrimeiroTesteTreinamento
    {
       // [Fact]
        public void Test1()
        {
            RestClient client = new RestClient("http://192.168.99.100:8989");
            RestRequest request = new RestRequest("/api/rest/issues/a", Method.GET);
            request.AddHeader("Authorization", "oStEP4yy1yKIwKchx8ExX7AO4sa5nbSy");
            var testeresponse = client.Execute(request);
            string retorno = testeresponse.StatusCode.ToString();
            Console.WriteLine("Retorno do Teste:" + retorno);
            Assert.Equal("OK", retorno);

        }

      
        [Fact]
        public void Test3()
        {
            RestClient client = new RestClient("https://petstore.swagger.io/v2");
            RestRequest request = new RestRequest("/pet/findByStatus", Method.GET);
            //request.AddParameter("status", "available");
            //request.AddHeader("Authorization", "oStEP4yy1yKIwKchx8ExX7AO4sa5nbSy");
            var testeresponse = client.Execute(request);
            string retorno = testeresponse.StatusCode.ToString();
            Console.WriteLine("Retorno do Teste:" + retorno);
            Assert.Equal("OK", retorno);
        }
    }
}
