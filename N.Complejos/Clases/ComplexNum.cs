using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics;


namespace N.Complejos.Clases
{
    public class ComplexNum
    {
        private Double Real;
        private Double Unreal;
        private Double r;
        private Double Teta;


        public ComplexNum(Double Real, Double Unreal)
        {
            this.Real = Math.Round(Real, 5, MidpointRounding.AwayFromZero);
            this.Unreal = Math.Round(Unreal, 5, MidpointRounding.AwayFromZero);
            r = Math.Sqrt(Math.Pow(Real, 2.0) + Math.Pow(Unreal, 2.0));
            Teta = Math.Atan2(Unreal, Real);
        }

        public ComplexNum(String num)
        {
            /*string pattern = @"(\s*) (i)";
              string replacement = "";
              Regex rgx = new Regex(pattern);
              num = rgx.Replace(num, replacement);*/
            bool isIm = (num.IndexOf('i') > 0);
            num = new string((from c in num
                              where char.IsDigit(c) || (c == '+') || (c == '-')
                              select c
               ).ToArray());

            int mid = (num.IndexOf('-', 1) == -1)? 
                            num.IndexOf("+", 1)
                        :
                            num.IndexOf('-', 1);

            if (mid == -1) {
                Real = (isIm)? 0 : Convert.ToDouble(num.Substring(0, num.Length));
                Unreal = (isIm)? Convert.ToDouble(num.Substring(0, num.Length)) : 0;
            }
            else {
                Real = Convert.ToDouble(num.Substring(0, mid));
                Unreal = Convert.ToDouble(num.Substring(mid));
            }

            r = Math.Sqrt(Math.Pow(Real, 2.0) + Math.Pow(Unreal, 2.0));
            Teta = Math.Atan2(Unreal, Real);
        }

        public Double getReal()
        {
            return Real;
        }

        public Double getUnreal()
        {
            return Unreal;
        }

        public Double getr()
        {
            return r;
        }

        public Double getTeta()
        {
            return Teta;
        }

        public ComplexNum Sum(Double Real, Double Unreal)
        {
            return new ComplexNum((this.Real + Real), (this.Unreal + Unreal));
        }
        public ComplexNum Sum(ComplexNum _X)
        {
            return new ComplexNum((_X.Real + Real), (_X.Unreal + Unreal));
        }

        public ComplexNum Res(Double Real, Double Unreal)
        {
            return new ComplexNum((this.Real - Real), (this.Unreal - Unreal));
        }

        public ComplexNum Res(ComplexNum _X)
        {
            return new ComplexNum((-_X.Real + Real), (-_X.Unreal + Unreal));
        }

        public ComplexNum Mul(Double Real, Double Unreal)
        {
            return new ComplexNum((this.Real * Real) - (this.Unreal * Unreal), (this.Unreal * Real) + (this.Real * Unreal));
        }

        public ComplexNum Mul(ComplexNum _X)
        {
            return new ComplexNum((Real * _X.getReal()) - (Unreal * _X.getUnreal()), (Unreal * _X.getReal()) + (Real * _X.getUnreal()));
        }

        public ComplexNum Div(Double Real, Double Unreal)
        {
            if(Real + Unreal != 0){
                var A = Matrix<double>.Build.DenseOfArray(new double[,] {
                    { Real, -Unreal },
                    { Unreal, Real }
                });
                var b = Vector<double>.Build.Dense(new double[] { this.Real, this.Unreal });
                var x = A.Solve(b);
                return new ComplexNum(x.At(0), x.At(1));
            } else return null;
            
        }

        public ComplexNum Div(ComplexNum _X)
        {
            if (_X.getReal() + _X.getUnreal() != 0)
            {
                var A = Matrix<double>.Build.DenseOfArray(new double[,] {
                    { _X.getReal(), -_X.getUnreal() },
                    { _X.getUnreal(), _X.getReal() }
                });
                var b = Vector<double>.Build.Dense(new double[] { Real, Unreal });
                var x = A.Solve(b);
                return new ComplexNum(x.At(0), x.At(1));
            }
            else return null;

        }

        public List<string> Roots(int n)
        {
            List<string> _Roots = new List<string>();
            for (int i = 0; i < n; i++)
                _Roots.Add("Z[" + i + "]\t" + (((Math.Pow(r, 1.0 / n) * Math.Cos((Teta + 2 * i * Math.PI) / n)) == 0)?"":"" + Math.Round(Math.Pow(r, 1.0 / n) * Math.Cos((Teta + 2 * i * Math.PI) / n), 5, MidpointRounding.AwayFromZero)) 
                    + (((Math.Pow(r, 1.0 / n) * Math.Sin((Teta + 2 * i * Math.PI) / n)) == 0)?"":(" + i" + Math.Round(Math.Pow(r, 1.0 / n) * Math.Sin((Teta + 2 * i * Math.PI) / n), 5, MidpointRounding.AwayFromZero) )));

            return _Roots;
        }

        public List<ComplexNum> Roots_Num(int n)
        {
            List<ComplexNum> _Roots = new List<ComplexNum>();
            for (int i = 0; i < n; i++)
                _Roots.Add(new ComplexNum(Math.Pow(r, 1.0 / n) * Math.Cos((Teta + 2 * i * Math.PI) / n), Math.Pow(r, 1.0 / n) * Math.Sin((Teta + 2 * i * Math.PI) / n)));

            return _Roots;
        }

        public ComplexNum SqrC()
        {
            return(new ComplexNum(Math.Pow(r, 1.0 / 2) * Math.Cos((Teta * Math.PI) / 2), Math.Pow(r, 1.0 / 2) * Math.Sin((Teta + 2 * Math.PI) / 2)));

            
        }

        public ComplexNum Pow(int n)
        {
            return  (n >= 0)?
                    ((Real == 0 && Unreal == 0) ? 
                        new ComplexNum(0, 0) 
                        : 
                        new ComplexNum(Math.Pow(r, n) * Math.Cos(n * Teta), Math.Pow(r, n) * Math.Sin(n * Teta))) 
                    :
                    (new ComplexNum((Real / (Math.Pow(Real,2) + Math.Pow(Unreal, 2.0))), ((-1 * Unreal) / (Math.Pow(Real, 2.0) + Math.Pow(Unreal, 2.0))) )).Pow(Math.Abs(n));
        }

        public ComplexNum Sen()
        {
            return new ComplexNum((Math.Sin(Real) * ((Math.Exp(Unreal) + Math.Exp(-1 * Unreal)) / 2)), 
                (Math.Cos(Real) * ((Math.Exp(Unreal) - Math.Exp(-1 * Unreal)) / 2)));
        }             

        public ComplexNum Cos()
        {
            return new ComplexNum((Math.Cos(Real) * ((Math.Exp(Unreal)) + Math.Exp(-1 * Unreal)) / 2),
                (Math.Sin(Real) * -1 * ((Math.Exp(Unreal) - Math.Exp(-1 * Unreal)) / 2)));
        }

        public ComplexNum E_Z()
        {
            return new ComplexNum((Math.Pow(Math.E, Real) * Math.Cos(Unreal)),
            (Math.Pow(Math.E, Real) * Math.Sin(Unreal)));
        }

        public ComplexNum Ln()
        {
            return new ComplexNum(Math.Log(r), Teta);
        }

        public ComplexNum Tan(ComplexNum S, ComplexNum C)
        {
            return S.Div(C.getReal(),C.getUnreal());
        }

        public ComplexNum Csc(ComplexNum S)
        {
            return S.Pow(-1);
        }

        public ComplexNum Sec (ComplexNum c)
        {
            return c.Pow(-1);
        }

        public ComplexNum Cot(ComplexNum T)
        {
            return T.Pow(-1);
        }

        public ComplexNum Cosh()
        {//Cosh(Z) = (Cos(b) * ((ea + e-a) / 2) + Sin(b) * ((ea - e-a) / 2)i)
            return new ComplexNum((Math.Cos(Unreal) * ((Math.Exp(Real)) + Math.Exp(-1 * Real)) / 2),
                (Math.Sin(Unreal) * ((Math.Exp(Real) - Math.Exp(-1 * Real)) / 2)));
        }

        public ComplexNum Senh()
        {//Sinh(Z) = (Cos(b) * ((ea - e-a) / 2) + Sin(b) * ((ea + e-a) / 2)i)
            return new ComplexNum((Math.Cos(Unreal) * ((Math.Exp(Real) - Math.Exp(-1 * Real)) / 2)),
                (Math.Sin(Unreal) * ((Math.Exp(Real) + Math.Exp(-1 * Real)) / 2)));
        }

        public ComplexNum Tanh()
        {
            return Senh().Div(Cosh());
        }

        public ComplexNum ArcC()
        {
            Complex32 Piv = Complex32.Acos(new Complex32((float) Real, (float) Unreal));
            //return (((new ComplexNum(0.0, 1.0).Mul(Real, Unreal)).Sum((new ComplexNum(1.0, 00).Res(Pow(2))).SqrC())).Ln()).Mul(0.0, -1.0);
            return new ComplexNum(Piv.Real, Piv.Imaginary);
        }

        public ComplexNum ArcS()
        {
            Complex32 Piv = Complex32.Asin(new Complex32((float)Real, (float)Unreal));
            return new ComplexNum(Piv.Real, Piv.Imaginary);
        }

        public ComplexNum ArcT()
        {
            Complex32 Piv = Complex32.Atan(new Complex32((float)Real, (float)Unreal));
            return new ComplexNum(Piv.Real, Piv.Imaginary);
        }

        public string Printable()
        {
            return ((Real == 0)? 
                (Unreal == 0)? 
                    "0 + "
                    :
                    ""
                
                :
                        (
                            ((Real < 1000)? Real + ""
                            : 
                            Real.ToString("0.##E#")) 
                        )
                   ) 
                +  
                   ((Unreal == 0)? 
                       (Real == 0)? 
                            "0 i"
                            :
                            ""
                       :
                            (
                               ((Unreal > 0) ? 
                                   (Real == 0 )?
                                                ""
                                                :
                                                " + " 
                                   :
                                   " - ") + ((Unreal < 10000) ? 
                                                                Math.Abs(Unreal) + "" 
                                                                :
                                                                Math.Abs(Unreal).ToString("0.##E#")) + " i"
                            )
                    );
        }
    }
}
