using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalcLib
{
    public abstract class Shape {
        public abstract double Area { get; }
    }

    public class Triangle : Shape {
        double a;
        double b;
        double c;
        bool? isRectangular;
        double? area;
        public double A { get { return a; } }
        public double B { get { return b; } }
        public double C { get { return c; } }
        public bool IsRectangular {
            get {
                if(isRectangular == null)
                    isRectangular = calcIsRectangular(a, b, c);
                return (bool)isRectangular;
            }
        }
        public override double Area {
            get {
                if(area == null)
                    area = getAreaCore(a, b, c);
                return (double)area; }
        }
        public Triangle(double a, double b, double c) {
            validateSides(a, b, c);
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static double GetArea(double a, double b, double c) {
            validateSides(a, b, c);
            return getAreaCore(a, b, c);
        }
        public static bool CheckIsRectangular(double a, double b, double c) {
            validateSides(a, b, c);
            return calcIsRectangular(a, b, c);
        }

        static void validateSides(double a, double b, double c) {
            if((a <= 0) || (b <= 0) || (c <= 0))
                throw new ArgumentException("Triangle sides must be greater than zero");
            if((a + b <= c) || (a + c <= b) || (b + c <= a))
                throw new ArgumentException("One of sides is too large to create a correct triangle");
        }
        static double getAreaCore(double a, double b, double c) {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
        static bool calcIsRectangular(double a, double b, double c) {
            return (a*a +  b*b == c*c) || (a * a == b * b + c * c) || (a * a + c * c == b * b);
        }
    }

    public class Circle : Shape {
        double radius;
        double? area;
        public double Radius {
            get { return radius; }
        }
        public override double Area {
            get {
                if(area == null)
                    area = getAreaCore(radius);
                return (double)area; }
        }
        public Circle(double radius) {
            validateRadius(radius);
            this.radius = radius;
        }
        static double getAreaCore(double radius) {
            return Math.Pow(radius, 2) * Math.PI;
        }
        public static double GetArea(double radius) {
            validateRadius(radius);
            return Math.Pow(radius, 2) * Math.PI;
        }
        static void validateRadius(double radius) {
            if(radius <= 0)
                throw new ArgumentException("Radius must be greater than zero");
        }
    }
}
