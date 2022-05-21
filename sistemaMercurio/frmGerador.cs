using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaMercurio
{
    public partial class frmGerador : Form
    {
        public frmGerador()
        {
            InitializeComponent();
        }

        private void frmGerador_Load(object sender, EventArgs e)
        {
            var circulo = new System.Drawing.Drawing2D.GraphicsPath();
            circulo.AddEllipse(0, 0, 70, 70);

            lblNum1.Region = new Region(circulo);
            lblNum2.Region = new Region(circulo);
            lblNum3.Region = new Region(circulo);
            lblNum4.Region = new Region(circulo);
            lblNum5.Region = new Region(circulo);
            lblNum6.Region = new Region(circulo);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Random sorteio = new Random();

            for (int i = 1; i <= 6; i++) 
            {
                string numSort = sorteio.Next(61).ToString();
                if (numSort.Length == 1)
                {
                    numSort = "0" + numSort;
                }

                switch (i)
                {
                    case 1:
                        lblNum1.Text = numSort;
                        break;
                    case 2:
                        lblNum2.Text = numSort;
                        break;
                    case 3:
                        lblNum3.Text = numSort;
                        break;
                    case 4:
                        lblNum4.Text = numSort;
                        break;
                    case 5:
                        lblNum5.Text = numSort;
                        break;
                    case 6:
                        lblNum6.Text = numSort;
                        break;


                }

            }
        }
    }
}
