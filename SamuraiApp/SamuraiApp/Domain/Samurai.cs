using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Domain
{
    public class Samurai
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Clan Clan { get; set; }
        public Horse Horse { get; set; }
        public ICollection<Quote> Quotes { get; set; } = new List<Quote>();
        public ICollection<Battle> Battles { get; set; } = new List<Battle>();

    }


}
