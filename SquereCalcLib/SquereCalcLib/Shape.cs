using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalcLib
{
    public abstract class Shape {
        public abstract double Square { get; }
    }

    public class Triangle : Shape {
        double a;
        double b;
        double c;
        bool? isRectangular;
        double? square;
        public double A { get { return a; } }
        public double B { get { return b; } }
        public double C { get { return c; } }
        public bool IsRectangular {
            get {
                if(isRectangular == null)
                    isRectangular = CalcIsRectangular(a, b, c);
                return (bool)isRectangular;
            }
        }
        public override double Square {
            get {
                if(square == null)
                    square = GetSquareCore(a, b, c);
                return (double)square; }
        }
        public Triangle(double a, double b, double c) {
            CheckSides(a, b, c);
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static double GetSquare(double a, double b, double c) {
            CheckSides(a, b, c);
            return GetSquareCore(a, b, c);
        }
        public static bool ChaeckIsRectangular(double a, double b, double c) {
            CheckSides(a, b, c);
            return CalcIsRectangular(a, b, c);
        }

        static void CheckSides(double a, double b, double c) {
            if((a <= 0) || (b <= 0) || (c <= 0))
                throw new ArgumentException("Triangle sides must be greater than zero");
            if((a + b <= c) || (a + c <= b) || (b + c <= a))
                throw new ArgumentException("One of sides is too large to create a correct triangle");
        }
        static double GetSquareCore(double a, double b, double c) {
            double p = (a + b + c) / 2;
            double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return square;
        }
        static bool CalcIsRectangular(double a, double b, double c) {
            return (a*a +  b*b == c*c) || (a * a == b * b + c * c) || (a * a + c * c == b * b);
        }
    }

    public class Circle : Shape {
        double radius;
        double? square;
        public double Radius {
            get { return radius; }
        }
        public override double Square {
            get {
                if(square == null)
                    square = GetSquareCore(radius);
                return (double)square; }
        }
        public Circle(double radius) {
            CheckRadius(radius);
            this.radius = radius;
        }
        static double GetSquareCore(double radius) {
            return Math.Pow(radius, 2) * Math.PI;
        }
        public static double GetSquare(double radius) {
            CheckRadius(radius);
            return Math.Pow(radius, 2) * Math.PI;
        }
        static void CheckRadius(double radius) {
            if(radius <= 0)
                throw new ArgumentException("Radius must be greater than zero");
        }
    }
}
