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

            var Rnx = new double[] {0.0, 1.546135638*Math.Pow(10, -7), 4.058762217*Math.Pow(10, -8), 3.184226016*Math.Pow(10,-8), 3.127369828*Math.Pow(10,-8), 0.0};
            var x = new double[] { 0.0, Math.PI / 24, Math.PI / 20, Math.PI / 16, Math.PI / 12, Math.PI / 8 };
            var point = new FunctionInPoint(interp.CalcFunctionInPoint);
            var tablevalues = new double[2, 6] { { 0.0, Math.PI / 24, Math.PI / 20, Math.PI / 16, Math.PI / 12, Math.PI / 8 }, {point(x[0]), point(x[1]), point(x[2]), point(x[3]), point(x[4]), point(x[5]) } };

            myChart.Series[0].Color = Color.Red;
            var deviation = new Deviation(interp.CalcDeviation);
            var polynomial = new Polynomial(interp.CalcPolynomialInPoint);
            for( int i = 0; i < 6; ++i )
            {
                myChart.Series[0].Points.AddXY( tablevalues[0, i], tablevalues[1, i] );
                myChart.Series[1].Points.AddXY( tablevalues[0, i], tablevalues[1, i] );
                dataGridView1.Rows.Add(tablevalues[0, i], tablevalues[1, i], polynomial(x[i]), deviation(x[i], polynomial(x[i])), Math.Round(Rnx[i], 5));
                //dataGridView1.Rows.Add(interp.CalcPolynomialInPoint());
            }

            interp.CreateTable( tablevalues , 6 , 7 );
            mnogochlen.Text = interp.FormMnogochlen( 6 );
            var x_1 = interp.CalcPolynomialInPoint( 0.1 );
            var x_2 = interp.CalcPolynomialInPoint( 0.2 );
            var x_3 = interp.CalcPolynomialInPoint( 0.3 );
            var x_4 = interp.CalcPolynomialInPoint( Math.PI / 7 );


            x1.Text = "L(x`) = L(0.1) = " + x_1 +"\n";
            x1.Text += "L(x``) = L(0.2) = " + x_2 + "\n";
            x1.Text += "L(x```) = L(0.3) = " + x_3 + "\n";
            x1.Text += "L(x) = L(Pi/10) = " + x_4 + "\n";
            
            var interpTable = interp.InterpValue;
            OutputInterp( interpTable, 6, 7 );

            /*
            dataGridView2.Rows.Add( 0.1, interp.CalcDeviation(0.1, x_1 ));
            dataGridView2.Rows.Add( 0.2, interp.CalcDeviation( 0.2, x_2 ) );
            dataGridView2.Rows.Add( 0.3, interp.CalcDeviation( 0.3, x_3 ) );
            dataGridView2.Rows.Add( Math.PI/7, interp.CalcDeviation( Math.PI / 7, x_4 ) );
            */
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
    }
}
