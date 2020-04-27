using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using laba1.Services;
namespace laba1.Services
{
    public class ValuesGetter : IValuesGetter
    {
        private Dictionary<string, string> digits;
        private ResultsInitializer results;
        public ValuesGetter()
        {
            this.digits = new Dictionary<string, string>();
            this.results = new ResultsInitializer();
            this.setOperationsValues("add", this.results.results.first, "+", this.results.results.second, this.results.results.add);
            this.setOperationsValues("sub", this.results.results.first, "-", this.results.results.second, this.results.results.sub);
            this.setOperationsValues("mult", this.results.results.first, "*", this.results.results.second, this.results.results.mult);
            this.setOperationsValues("div", this.results.results.first, "/", this.results.results.second, this.results.results.div);
        }
        private void setOperationsValues(string operation, int first, string sign, int second, int result)
        {
            this.digits.Add(operation, first.ToString() + sign+ second.ToString() + "=" + result.ToString());
        }
        public int getFirst()
        {
            return this.results.results.first;
        }
        public int getSecond()
        {
            return this.results.results.second;
        }
        public Dictionary<string, string> getOperationsValues()
        {
            return this.digits;
        }
    }
}
