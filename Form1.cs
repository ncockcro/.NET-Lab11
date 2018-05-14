/*
 * Written by: Nicholas Cockcroft
 * Date: April 10, 2018
 * Course: .NET Environment
 * Assignment: Lab 11
 * 
 * Description: Write a program to graph the SINE function for a range of values specified by the user. 
 * (The range is a start and end x value for the graph.)  The graph you draw of the sine function should 
 * look smooth.  Make sure your graph does not overlap the range text box. 
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {

        // Global variables used throughout
        int fromNumCheck = 0; // Checks to ensure the user pressed enter for from text box
        int toNumCheck = 0;  // Checks to ensure the user pressed enter for to text box
        float sine_start = 0f;
        float sine_end = 0f;


        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphicsObject = e.Graphics;


            base.OnPaint(e);

            // create text brush
            SolidBrush textBrush = new SolidBrush(Color.Black);

            // create solid brush
            SolidBrush brush = new SolidBrush(Color.White);

            // draw white background
            // x1 = 50 y1 = 120          width = 750 height = 300
            graphicsObject.FillRectangle(brush, 0, 120, 750, 300);

            // Drawing the 0 at the center of the screen
            graphicsObject.DrawString("0", this.Font, textBrush, 350, 275);

            // Get the length of how long
            float length = sine_end - sine_start;

            drawAxes(graphicsObject);

            // Making sure the length is not negative
            if(length < 0)
            {
                MessageBox.Show("To clause is before the from clause. Can not graph sine wave.");
                return;
            }

            // Need to allocate 10 times the length for the size of the array since
            // I will be incrementing by 0.1 each time to store a new point later

            double[] x = new double[Convert.ToInt32(length) * 10];
            double[] y = new double[Convert.ToInt32(length) * 10];


            // If the user has entered two numbers...
            if (fromNumCheck > 0 && toNumCheck > 0)
            {

                double increment = 0.0;
                for (int i = 0; i < length * 10; i++)
                {
                    // Store the x value and add 350 so it starts at 0 and the y value which is just the sine of original x
                    try
                    {
                        x[i] = sine_start + increment + 350;
                        y[i] = Math.Sin(sine_start + increment);
                    }
                    catch(Exception)
                    {
                        continue;
                    }

                    // Incrementing by 0.1 each time to make a very "smooth" curve
                    increment = increment + 0.1;
                }
                
            }

            // Send over the x and y arrays, graphics object, and length the user specified to be drawn
            graphPoints(x, y, graphicsObject, length);


        }

        // Graphs the x and y axis as well as the sine graph
        void graphPoints(double[] x, double[] y, Graphics g, float length)
        {
            // Uses anti aliasing to make the graph look a little more smooth
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Creating a blue pen to be used for drawing the sine waves
            Pen bluePen = new Pen(Color.Black, 1 / g.DpiX);

            // Ensuring the user typed in 2 numbers...
            if (fromNumCheck > 0 && toNumCheck > 0)
            {
                Size size = new Size(750, 300);

                // Get the max and min x and y values.
                double maxX = maxValue(x);
                double maxY = maxValue(y);
                double minX = minValue(x);
                double minY = minValue(y);

                // Creating new arrays for where the pixel values will go for x and y
                double[] px = new double[x.Length];
                double[] py = new double[y.Length];

                // Scale the points to pixels.
                for (int ip = 0; ip < x.Length; ip++)
                {
                    px[ip] = (x[ip] - minX) / (maxX - minX) * (size.Width - sine_start - 375) + Math.Abs(x[ip]);
                    py[ip] = size.Height - (y[ip] - minY) / (maxY - minY) * 100 + 28;
                }


                // Draw all of the lines from points
                for (int ip = 1; ip < x.Length; ip++)
                {
                    if (px[ip] < 750)
                    {
                        g.DrawLine(bluePen, (float)px[ip - 1], (float)py[ip - 1], (float)px[ip], (float)py[ip]);
                    }
                }
            }

        }

        void drawAxes(Graphics g)
        {
            // Using a blue pen for drawing the axes
            Pen bluePen = new Pen(Color.Black, 1 / g.DpiX);

            // Values used for drawing x and y axis
            float x0 = 0;
            float y0 = 200f;

            using (Pen p = new Pen(Color.Blue))

            {
                //Draw X-coordinate
                g.DrawLine(p, x0, y0 + 75, x0 + 750, y0 + 75);

                //Draw Y-coordinate
                g.DrawLine(p, x0 + 350, y0 + 220, x0 + 350, y0 - 80);

            }
        }

        // Gets the maximum values from a list of points
        double maxValue(double[] x)
        {
            double max = x[0];
            foreach (double a in x)
            {
                if (max < a) max = a;
            }
            return max;
        }
        // Gets the minimum values from a list of points
        double minValue(double[] x)
        {
            double min = x[0];
            foreach (double a in x)
            {
                if (min > a) min = a;
            }
            return min;
        }
        private void fromTextBox_keyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter)
                {
                    return;
                }

                sine_start = float.Parse(fromTextBox.Text);
                fromNumCheck++;

                Invalidate();
            }
            catch(Exception)
            {
                return;
            }

            
        }

        private void toTextBox_keyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter)
                {
                    return;
                }

                sine_end = float.Parse(toTextBox.Text);
                toNumCheck++;

                Invalidate();
            }
            catch(Exception)
            {
                return;
            }


        }

        private void fromTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fromLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
