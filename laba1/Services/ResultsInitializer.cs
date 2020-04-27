using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using laba1.Models;
namespace laba1.Services
{
    public class ResultsInitializer
    {
        public Results results{get; set;}
        public ResultsInitializer()
        {
            var rand = new Random();
            int first = rand.Next(1, 10);
            int second = rand.Next(1, 10);
            int add = first + second;
            int sub = first - second;
            int mult = first * second;
            int div = second == 0 ? 0 : first / second;
            this.results = new Results()
            {
                first = first,
                second = second,
                add = add,
                sub = sub,
                mult = mult,
                div = div
            };
        }
    }
}
