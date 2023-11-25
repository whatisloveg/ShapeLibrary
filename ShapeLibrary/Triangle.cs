using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Triangle : IShape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this._sideA = sideA;
            this._sideB = sideB;
            this._sideC = sideC;

            if (sideA + sideB <= sideC || sideB + sideC <= sideA || sideC + sideA <= sideB)
            {
                throw new ArgumentException("Triangle cannot exist");
            }
        }

        public double CalculateArea()
        {
            double semiPerimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
        }

        public bool IsRightTriangle()
        {
            double[] sides = { _sideA, _sideB, _sideC };
            double hyptenuse = 0;
            double firstSide = 0;
            double secondSide = 0;

            for (int i = 1; i < sides.Length; i++)
            {
                if (sides[i] > sides[i - 1])
                {
                    hyptenuse = sides[i];
                }
            }

            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i] != hyptenuse)
                {
                    firstSide = sides[i];
                    break;
                }
            }

            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i] != hyptenuse & sides[i] != firstSide)
                {
                    secondSide = sides[i];
                    break;
                }
            }

            if (hyptenuse == Math.Sqrt(Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
