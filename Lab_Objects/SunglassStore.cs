using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Objects
{
    public class SunglassStore
    {
        public List<Sunglasses> _stock;

        internal List<Sunglasses> Stock { get => _stock; }

        public void AddSunglasses(Sunglasses sunglasses)
        {
            _stock.Add(sunglasses);
        }

        public override string ToString()
        {
            return $"{_stock}";
        }



    }
}