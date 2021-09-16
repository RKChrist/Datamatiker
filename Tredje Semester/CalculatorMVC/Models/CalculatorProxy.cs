using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorMVC.Models
{
    public interface ICalculate
    {
        Task<int> Add(int a, int b);
        Task<int> Subtract(int a, int b);
        Task<Stream> Download();
    }
    public class CalculatorProxy : ICalculate
    {
        private readonly HttpClient _client = new HttpClient();
        // public CalculatorProxy(HttpClient client)
        // {
        //     _client = client;
        // }


        public async Task<int> Add(int a, int b)
        {
            int returnValue = 0;
            try
            {
                string uri = $"http://localhost:5555/Calculator/Add/?a={a}&b={b}";
                returnValue = Int32.Parse(await _client.GetStringAsync(uri));
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return returnValue;
        }
        public async Task<int> Subtract(int a, int b)
        {
            int returnValue = 0;
            try
            {
                string uri = $"http://localhost:5555/Calculator/Subtract/?a={a}&b={b}";
                returnValue = Int32.Parse(await _client.GetStringAsync(uri));
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return returnValue;
        }

        public async Task<Stream> Download()
        {
            string uri = $"http://localhost:5555/Calculator/Download/qwerty";
            var memory = new MemoryStream();
            using (var stream = await _client.GetStreamAsync(uri).ConfigureAwait(false))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return memory;


        }
    }
}