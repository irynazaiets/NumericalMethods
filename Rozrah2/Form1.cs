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
        delegate double FunctionInPoint(double dot);
        delegate double Deviation(double dot, double polinomialValue);
        delegate double Polynomial(double dot);
        public Form1( )
        {
            InitializeComponent( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            dataGridView1.Rows.Clear( );
            var interp = new Interpolation( );

            var Rnx = new double[] { 4.058762217*Math.Pow(10, -8), 3.184226016*Math.Pow(10,-8), 3.127369828*Math.Pow(10,-8), 0.0};
            var x = new double[] { 0.0, Math.PI / 24, Math.PI / 20, Math.PI / 16, Math.PI / 12, Math.PI / 8 };
            var point = new FunctionInPoint(interp.CalcFunctionInPoint);
            var tablevalues = new double[2, N+1] { { 0.0, Math.PI / 24, Math.PI / 20, Math.PI / 16, Math.PI / 12, Math.PI / 8 }, {point(x[0]), point(x[1]), point(x[2]), point(x[3]), point(x[4]), point(x[5]) } };

            myChart.Series[0].Color = Color.Red;
            var deviation = new Deviation(interp.CalcDeviation);
            var polynomial = new Polynomial(interp.CalcPolynomialInPoint);
            for( int i = 0; i < N + 1; ++i )
            {
                myChart.Series[0].Points.AddXY( tablevalues[0, i], tablevalues[1, i] );
                myChart.Series[1].Points.AddXY( tablevalues[0, i], tablevalues[1, i] );
                dataGridView1.Rows.Add(tablevalues[0, i], tablevalues[1, i], polynomial(x[i]));
                //deviation(x[i], polynomial(x[i])), Math.Round(Rnx[i], N)
            }

            interp.CreateTable( tablevalues , N + 1, N + 2);
            mnogochlen.Text = interp.FormMnogochlen(N + 1);
            var addings = new double[] { 0.1, 0.2, 0.3, Math.PI / 7 };
            var x_1 = polynomial(addings[0]);
            var x_2 = polynomial(addings[1]);
            var x_3 = polynomial(addings[2]);
            var x_4 = polynomial(addings[3]);

            var polynomialInPoints = new double[] { x_1, x_2, x_3, x_4 };
            x1.Text = "L(x`) = L(0.1) = " + x_1 +"\n";
            x1.Text += "L(x``) = L(0.2) = " + x_2 + "\n";
            x1.Text += "L(x```) = L(0.3) = " + x_3 + "\n";
            x1.Text += "L(x) = L(Pi/7) = " + x_4 + "\n";
            
            var interpTable = interp.InterpValue;
            OutputInterp( interpTable, N + 1, N + 2);

            for (int i = 0; i < N-1; ++i)
            {
                dataGridView3.Rows.Add(addings[i], deviation(addings[i], polynomialInPoints[i]),Rnx[i]);
            }
        }

        #region MyCustomOutput
        public void OutputInterp( double[,] matrix, double countOfRow, int countOfCol )
        {
            label5.Text =  "Table of divided differences:\n";
            for( int e = 0; e < countOfRow; ++e )
            {
                for( int w = 0; w < countOfCol; ++w )
                {
                    if( e > 0 && w>1 && matrix[e, w] == 0 )
                    {
                        label5.Text += "         " ;
                    } else
                    {
                        if( matrix[e, w] >= 0 )
                            label5.Text += String.Format( " {0:#,##0.00000}", matrix[e, w] ) + "  " ;
                        else
                            label5.Text += String.Format( "{0:#,##0.00000}", matrix[e, w] ) + "  " ;
                    }
                }
                label5.Text += "\n";
            }
        }
        #endregion
        private void Form1_Load( object sender, EventArgs e )
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
