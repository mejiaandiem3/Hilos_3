using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hilos_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread h1, h2, h3;
        Random rd = new Random();

        private void btnporceso1_Click(object sender, EventArgs e)
        {
            h1 = new Thread(new ThreadStart(Proceso1));
            h1.Start();
           // h1.Join();
        }


        private void btnporceso2_Click(object sender, EventArgs e)
        {
            h2 = new Thread(new ThreadStart(Proceso2));
            h2.Start();
            //h2.Join();
        }


        private void btnporceso3_Click(object sender, EventArgs e)
        {
            h3 = new Thread(new ThreadStart(Proceso3));
            h3.Start();
            //h3.Join();

        }


        public void Proceso1()
        {
            for (int i = 0; i < 300; i++)
            {
                try
                {
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rd.Next(0, this.Width), (rd.Next(0, this.Height)), 20, 20));
                }
                catch (Exception )
                {
                    MessageBox.Show("Se interrumpio el proceso");
                }

                //this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red,4),new Rectangle(rd.Next(0,this.Width), (rd.Next(0, this.Height)), 20, 20 ));

            }

            Thread.Sleep(1000);
            h1.Join();

        }

        public void Proceso2()
        {
            for (int i = 0; i < 300; i++)
            {
                try
                {
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(rd.Next(0, this.Width), (rd.Next(0, this.Height)), 20, 20));
                }
                catch (Exception )
                {
                    MessageBox.Show("Se interrumpio el proceso");
                }


                //this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(rd.Next(0, this.Width), (rd.Next(0, this.Height)), 20, 20));

            }

            Thread.Sleep(1000);
            h2.Join();
        }

        public void Proceso3()
        {
            for (int i = 0; i < 300; i++)
            {
                try
                {
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Violet, 4), new Rectangle(rd.Next(0, this.Width), (rd.Next(0, this.Height)), 20, 20));
                }
                catch (Exception )
                {
                    MessageBox.Show("Se interrumpio el proceso");
                }

                //this.CreateGraphics().DrawRectangle(new Pen(Brushes.Violet, 4), new Rectangle(rd.Next(0, this.Width), (rd.Next(0, this.Height)), 20, 20));

            }

            Thread.Sleep(1000);
            h3.Join();
        }
         

    }
}
