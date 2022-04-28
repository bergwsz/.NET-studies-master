using System;

namespace OOP.FirstExercises.Classes
{
    internal class TriangleExercise
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2;
            double sqrtRoot = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return sqrtRoot;
        }
    }
}
