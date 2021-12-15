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
        /// <summary>
        /// 
        /// </summary>
        public double Real { get; }
        /// <summary>
        /// 
        /// </summary>
        public double Imaginary { get; }
        /// <summary>
        /// 
        /// </summary>
        public double Modulus =>
            Math.Sqrt(this.Real * this.Real + this.Imaginary * this.Imaginary);
        /// <summary>
        /// 
        /// </summary>
        public double Phase =>
            Math.Atan2(this.Imaginary, this.Real);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="real"></param>
        /// <param name="imaginary"></param>
        public Complex(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public Complex Plus(Complex num) => 
            new Complex(this.Real + num.Real, this.Imaginary + num.Imaginary);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Complex Complement() =>
            new Complex(this.Real, -this.Imaginary);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public Complex Minus(Complex num) =>
            new Complex(this.Real - num.Real, this.Imaginary - num.Imaginary);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (this.Imaginary == 0.0) return this.Real.ToString(); 
            if (this.Real == 0.0)
            {
                return this.Imaginary + "i";
            }
            string sign = this.Imaginary > 0 ? "+" : ""; 
            return this.Real + sign + this.Imaginary + "i";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Complex)obj);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="complex"></param>
        /// <returns></returns>
        public  bool Equals(Complex complex)
        {
            return this.Imaginary.Equals(complex.Imaginary) && this.Real.Equals(complex.Real);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => 
            HashCode.Combine(this.Real, this.Imaginary);
    }
}