using System;

namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        
        public double Real { get; }
        
        public double Imaginary { get; }
        
        public double Modulus =>
            Math.Sqrt(this.Real * this.Real + this.Imaginary * this.Imaginary);
        
        public double Phase =>
            Math.Atan2(this.Imaginary, this.Real);
        
        public Complex(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }
        
        public Complex Plus(Complex num) => 
            new Complex(this.Real + num.Real, this.Imaginary + num.Imaginary);
        
        public Complex Complement() =>
            new Complex(this.Real, -this.Imaginary);
        
        public Complex Minus(Complex num) =>
            new Complex(this.Real - num.Real, this.Imaginary - num.Imaginary);

        public override string ToString()
        {
            if (Imaginary == 0.0) return Real.ToString();
            string signAndImaginary = Imaginary > 0 ? "+" : "";
            signAndImaginary = Imaginary != 1 ? $"{signAndImaginary}{Imaginary}" : signAndImaginary;
            if (Real == 0.0)
            {
                return $"{signAndImaginary}i";
            }
            return $"{Real}{signAndImaginary}i";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Complex)obj);
        }

        public  bool Equals(Complex complex)
        {
            return this.Imaginary.Equals(complex.Imaginary) && this.Real.Equals(complex.Real);
        }

        public override int GetHashCode() => 
            HashCode.Combine(this.Real, this.Imaginary);
    }
}