using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.Models
{
    public class TimesEtapa
    {
        public string Etapa { get; set; }
        public List<Tuple<string, DateTime>> Times { get; set; }
        public int? TimeTotalEtapa { get; set; }

        public TimesEtapa(string etapa)
        {
            this.Etapa = etapa;
            Tuple<string, DateTime> a = Tuple.Create("Entrada", DateTime.Now);
            this.Times = new() {a};
        }
}
}
