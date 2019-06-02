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
        public Form1( )
        {
            InitializeComponent( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            dataGridView1.Rows.Clear( );
            var interp = new Interpolation( );
            var tablevalues = new double[2, 6] { { 0.0, Math.PI / 24, Math.PI / 20, Math.PI / 16, Math.PI / 12, Math.PI / 8 }, 
                {interp.CalcFunctionInPoint(0.0), interp.CalcFunctionInPoint(Math.PI / 24), interp.CalcFunctionInPoint(Math.PI / 20), 
                    interp.CalcFunctionInPoint(Math.PI / 16), interp.CalcFunctionInPoint(Math.PI / 12), interp.CalcFunctionInPoint(Math.PI / 8) } };

            myChart.Series[0].Color = Color.Red;
            for( int i = 0; i < 6; ++i )
            {
                myChart.Series[0].Points.AddXY( tablevalues[0, i], tablevalues[1, i] );
                myChart.Series[1].Points.AddXY( tablevalues[0, i], tablevalues[1, i] );
                dataGridView1.Rows.Add( tablevalues[0, i], tablevalues[1, i] );
            }

            interp.CreateTable( tablevalues , 6 , 7 );
            mnogochlen.Text = interp.FormMnogochlen( 6 );
            var x_1 = interp.CalcPolynomialInPoint( 0.1 );
            var x_2 = interp.CalcPolynomialInPoint( 0.2 );
            var x_3 = interp.CalcPolynomialInPoint( 0.3 );
            var x_4 = interp.CalcPolynomialInPoint( Math.PI / 10 );


            x1.Text = "L(x`) = L(0.1) = " + x_1 +"\n";
            x1.Text += "L(x``) = L(0.2) = " + x_2 + "\n";
            x1.Text += "L(x```) = L(0.3) = " + x_3 + "\n";
            x1.Text += "L(x) = L(Pi/10) = " + x_4 + "\n";
            
            var interpTable = interp.InterpValue;
            OutputInterp( interpTable, 6, 7 );

            dataGridView2.Rows.Add( 0.1, interp.CalcDeviation(0.1, x_1 ));
            dataGridView2.Rows.Add( 0.2, interp.CalcDeviation( 0.2, x_2 ) );
            dataGridView2.Rows.Add( 0.3, interp.CalcDeviation( 0.3, x_3 ) );
            dataGridView2.Rows.Add( Math.PI/10, interp.CalcDeviation( Math.PI / 10, x_4 ) );

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
