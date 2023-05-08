using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Objects
{
    public class Sunglasses
    {
        public enum Lenses { prescriptiom, reading, mirrored, photochromic, gradient }
        Lenses lenses;

        enum LensMatierial { glass, plastic, polycarbonate }
        LensMatierial lensMatierial;

        enum LensColor { gray, brown, amber, green, yellow, blue, purple, red, pink }
        LensColor lensColor;

        bool polarized; // Are the lenses polarized or non-polarized

        enum Frame { fullRim, halfRim, rimless, clipOn }
        Frame frame;

        enum FrameShape { aviator, clubmaster, catEye, wayfarer, round, butterfly, browline, heart }
        FrameShape frameShape;

        enum FrameMaterial { plastic, metal, wood }
        FrameMaterial frameMaterial;

        string frameColor;

        string framePattern;

        string brand;

        public Sunglasses(Lab_Objects.Lenses lense)
        {
            Lense = lense;
        }

        public Lenses Lenses1 { get => lenses; set => lenses = value; }
        private LensMatierial LensMatierial1 { get => lensMatierial; set => lensMatierial = value; }
        private LensColor LensColor1 { get => lensColor; set => lensColor = value; }
        public bool Polarized { get => polarized; set => polarized = value; }
        private Frame Frame1 { get => frame; set => frame = value; }
        private FrameShape FrameShape1 { get => frameShape; set => frameShape = value; }
        private FrameMaterial FrameMaterial1 { get => frameMaterial; set => frameMaterial = value; }
        public string FrameColor { get => frameColor; set => frameColor = value; }
        public string FramePattern { get => framePattern; set => framePattern = value; }
        public string Brand { get => brand; set => brand = value; }
        public Lab_Objects.Lenses Lense { get; }
    }
}
