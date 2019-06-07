using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozrah2
{
    public partial class Form1 : Form
    {
        public const int N = 5;
        public const double a = 0;
        public const double b = Math.PI / 8;
        public const double h = b/N;
		public const int K = 4;

        delegate double FunctionInPoint(double dot);
        delegate double Deviation(double dot);
        delegate double Polynomial(double dot);
        public Form1( )
        {
            InitializeComponent( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            dvgInterpPolynom.Rows.Clear( );
            var interp = new Interpolation();
            var Rnx = new double[K] { 4.058762217E-8, 3.184226016E-8, 3.127369828E-8, 0.0};
            var x = new double[N + 1];
            var y = new double[N + 1];
            var function_in_point = new FunctionInPoint(interp.ReturnFunction);
            var deviation = new Deviation(interp.CalcDeviation);
            myChart.Series[0].Color = Color.Red;
            for (int i = 0; i < N + 1; ++i)
            {
                x[i] = a + i * h;
                y[i] =function_in_point(x[i]);

                myChart.Series[0].Points.AddXY( x[i], y[i] );
                myChart.Series[1].Points.AddXY( x[i], y[i] );
                dvgInterpPolynom.Rows.Add(x[i], y[i]);
            }
			
            interp.CreateTable( x, y, N + 1, N + 2);
			mnogochlen.Text = interp.FormMnogochlen(N + 1);
			var addings = new double[K] { 0.1, 0.2, 0.3, a+h };
			
            var polynomialInPoints = new double[] { interp.CalcPolynomialInPoint(addings[0]), interp.CalcPolynomialInPoint(addings[1]), interp.CalcPolynomialInPoint(addings[2]), interp.CalcPolynomialInPoint(addings[3]) };

            var interpTable = interp.InterpValue;
            OutputInterp( interpTable, N + 1, N + 2);

            for (int i = 0; i < K; ++i)
            {
				double xR = addings[i];
				double yR = function_in_point(xR);
				double pR = polynomialInPoints[i];
				dvgInterpDeviation.Rows.Add(xR,yR, pR, Math.Round(deviation(xR), 15), Rnx[i]);
            }
        }

        #region MyCustomOutput
        public void OutputInterp( double[,] matrix, double countOfRow, int countOfCol )
        {
            DividedDifferences.Text =  "Таблиця розділених різниць\n\n";
            for( int e = 0; e < countOfRow; ++e )
            {
                for( int w = 0; w < countOfCol; ++w )
                {
                    if( e > 0 && w>1 && matrix[e, w] == 0 )
                    {
						DividedDifferences.Text += "         " ;
                    } else
                    {
                        if( matrix[e, w] >= 0 )
							DividedDifferences.Text += String.Format( " {0:#,##0.00000}", matrix[e, w] ) + "  " ;
                        else
							DividedDifferences.Text += String.Format( "{0:#,##0.00000}", matrix[e, w] ) + "  " ;
                    }
                }
				DividedDifferences.Text += "\n";
            }
        }
        #endregion
        private void Form1_Load( object sender, EventArgs e )
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void dvgInterpDeviation_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void myChart_Click(object sender, EventArgs e)
		{

		}

		private void dvgInterpPolynom_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
