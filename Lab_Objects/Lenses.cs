using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Objects
{
    public class Lenses
    {
        public enum Style { prescriptiom, reading, mirrored, photochromic, gradient }
        Style _style;

        public bool Lense { get; internal set; }

        public Lenses(Style style)
        {
            _style = style;
        }

        public override string ToString()
        {
            return $"{_style}";
        }


        //This was my first attempt that had too many erros so I started over:
        //public Style _style { get => _style; set => _style = value; }
        //public Style Mirrored { get; }

        //public Lenses(Style style, Lenses lense, Sunglasses sunglasses)
        //{
        //    this.style = style;
        //    this.lense = lense;
        //    this.sunglasses = sunglasses;
        //}

        //public Lenses(Style mirrored)
        //{
        //    Mirrored = mirrored;
        //}

        //Lenses lense = new Lenses(Style.mirrored);
        //Sunglasses sunglasses = new Sunglasses(lense);

    }
}
