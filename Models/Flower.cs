using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowwersAppNew.Models
{
    public enum FlowerUpkeepDifficulty
    {
        Easy,
        medium,
        Hard
    }
    public class Flower
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public long MarketPrice { get; set; }
        public FlowerUpkeepDifficulty flowerUpkeepDifficulty { get; set; }
    }
}
