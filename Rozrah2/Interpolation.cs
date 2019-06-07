using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozrah2
{
    public class Interpolation
    {
        public const int N = 5;
        private double[,] _interpValue;
        private int _rowCount;

        public double[,] InterpValue {
            get { return _interpValue; } 
            set { _interpValue = value; }
        } 
        
        public Interpolation( ) {
            InterpValue = new double[N+1, N + 5];
        }

        public void CreateTable( double[] matrix1, double[] matrix2, int rowCount, int columnCount ) {
            _rowCount = rowCount;
            for( int i = 0; i < _rowCount; ++i ) {
                InterpValue[i, 0] = matrix1[i];
                InterpValue[i, 1] = matrix2[i];
            }

            for( int i = 1; i < _rowCount; ++i ) {
                for( int j = 0; j < _rowCount - i; ++j ) {

                    //Знаходимо розділені різниці

                    var newElem = ( InterpValue[j, i] - InterpValue[j + 1, i] ) / ( InterpValue[j, 0] - InterpValue[j + i, 0] );
                    InterpValue[j, i + 1] = newElem;
                }
            }
        }
        //Обчислення значення інтерполяційного многочлена в заданій точці

        public double CalcPolynomialInPoint( double dot )
		{
            double L_horn = InterpValue[0, N + 1];
            for ( int j = (N + 1) - 2; j >= 0; --j )
                L_horn = InterpValue[0, j + 1] + ( dot - InterpValue[j, 0] ) * L_horn;
            return L_horn;
 
		}
		//Обчислення значення функції в заданій точці 

		public double ReturnFunction( double dot )
		{
			return  Math.Sin(3 * dot)/24 + Math.Pow(dot, 5)/64;
		}

		//Обчислюємо похибки інтерполяції в точках

		public double CalcDeviation(double dot)
		{
			return Math.Abs(ReturnFunction( dot ) - CalcPolynomialInPoint(dot));
		}

		public string FormMnogochlen( int n )
		{
			string anotherStr = Math.Round( InterpValue[0, N + 1],N).ToString();
        
			//формуємо інтерполяційний многочлен
        
			for(int j = n-2; j>=0;--j )
			{
				var s = $"({anotherStr})";
				anotherStr = InterpValue[j, 0]>= 0? InterpValue[j, 0] == 0 ? $"{Math.Round( InterpValue[0,j+1], N)}+x" : $"{Math.Round( InterpValue[0, j + 1], N)}+(x-{Math.Round( InterpValue[j, 0], N)})" 
													: $"{Math.Round( InterpValue[0, j + 1], N)})+(x+{Math.Round( InterpValue[j, 0], N)})";
				anotherStr += s;
			}
		return "Інтерполяційний многочлен Ньютона \nL = " + anotherStr;
		}
    }
}
