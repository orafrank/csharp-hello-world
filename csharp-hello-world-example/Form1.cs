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


namespace csharp_hello_world_example
{
    public partial class Form1 : Form
    {
        CancellationTokenSource tokenSource = new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        async Task PutTaskDelay()
        {
           await Task.Delay(100, tokenSource.Token);        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Set all ForestGreen.
            richTextBox1.ForeColor = Color.ForestGreen;
            await Task.Delay(100);
            richTextBox2.ForeColor = Color.ForestGreen;
            await Task.Delay(100);
            richTextBox3.ForeColor = Color.ForestGreen;
            await Task.Delay(100);
            richTextBox4.ForeColor = Color.ForestGreen;
            await Task.Delay(100);
            richTextBox5.ForeColor = Color.ForestGreen;
            await Task.Delay(100);
            richTextBox10.ForeColor = Color.ForestGreen;
            await Task.Delay(100);
            richTextBox9.ForeColor = Color.ForestGreen;
            await Task.Delay(100);
            richTextBox8.ForeColor = Color.ForestGreen;
            await Task.Delay(100);
            richTextBox7.ForeColor = Color.ForestGreen;
            await Task.Delay(100);
            richTextBox6.ForeColor = Color.ForestGreen;
            await Task.Delay(400);  // Pause

            // Set all blue.
            richTextBox1.ForeColor = Color.Blue;
            await Task.Delay(100);
            richTextBox2.ForeColor = Color.Blue;
            await Task.Delay(100);
            richTextBox3.ForeColor = Color.Blue;
            await Task.Delay(100);
            richTextBox4.ForeColor = Color.Blue;
            await Task.Delay(100);
            richTextBox5.ForeColor = Color.Blue;
            await Task.Delay(100);
            richTextBox10.ForeColor = Color.Blue;
            await Task.Delay(100);
            richTextBox9.ForeColor = Color.Blue;
            await Task.Delay(100);
            richTextBox8.ForeColor = Color.Blue;
            await Task.Delay(100);
            richTextBox7.ForeColor = Color.Blue;
            await Task.Delay(100);
            richTextBox6.ForeColor = Color.Blue;
            await Task.Delay(400);  // Pause

            // Set all yellow.
            richTextBox1.ForeColor = Color.Yellow;
            await Task.Delay(100);
            richTextBox2.ForeColor = Color.Yellow;
            await Task.Delay(100);
            richTextBox3.ForeColor = Color.Yellow;
            await Task.Delay(100);
            richTextBox4.ForeColor = Color.Yellow;
            await Task.Delay(100);
            richTextBox5.ForeColor = Color.Yellow;
            await Task.Delay(100);
            richTextBox10.ForeColor = Color.Yellow;
            await Task.Delay(100);
            richTextBox9.ForeColor = Color.Yellow;
            await Task.Delay(100);
            richTextBox8.ForeColor = Color.Yellow;
            await Task.Delay(100);
            richTextBox7.ForeColor = Color.Yellow;
            await Task.Delay(100);
            richTextBox6.ForeColor = Color.Yellow;
            await Task.Delay(400);  // Pause

            // Set all cyan.
            richTextBox1.ForeColor = Color.Cyan;
            await Task.Delay(100);
            richTextBox2.ForeColor = Color.Cyan;
            await Task.Delay(100);
            richTextBox3.ForeColor = Color.Cyan;
            await Task.Delay(100);
            richTextBox4.ForeColor = Color.Cyan;
            await Task.Delay(100);
            richTextBox5.ForeColor = Color.Cyan;
            await Task.Delay(100);
            richTextBox10.ForeColor = Color.Cyan;
            await Task.Delay(100);
            richTextBox9.ForeColor = Color.Cyan;
            await Task.Delay(100);
            richTextBox8.ForeColor = Color.Cyan;
            await Task.Delay(100);
            richTextBox7.ForeColor = Color.Cyan;
            await Task.Delay(100);
            richTextBox6.ForeColor = Color.Cyan;
            await Task.Delay(400);  // Pause

            // Set all Orchid.
            richTextBox1.ForeColor = Color.Orchid;
            await Task.Delay(100);
            richTextBox2.ForeColor = Color.Orchid;
            await Task.Delay(100);
            richTextBox3.ForeColor = Color.Orchid;
            await Task.Delay(100);
            richTextBox4.ForeColor = Color.Orchid;
            await Task.Delay(100);
            richTextBox5.ForeColor = Color.Orchid;
            await Task.Delay(100);
            richTextBox10.ForeColor = Color.Orchid;
            await Task.Delay(100);
            richTextBox9.ForeColor = Color.Orchid;
            await Task.Delay(100);
            richTextBox8.ForeColor = Color.Orchid;
            await Task.Delay(100);
            richTextBox7.ForeColor = Color.Orchid;
            await Task.Delay(100);
            richTextBox6.ForeColor = Color.Orchid;
            await Task.Delay(400);  // Pause

            // Set all Maroon.
            richTextBox1.ForeColor = Color.Maroon;
            await Task.Delay(100);
            richTextBox2.ForeColor = Color.Maroon;
            await Task.Delay(100);
            richTextBox3.ForeColor = Color.Maroon;
            await Task.Delay(100);
            richTextBox4.ForeColor = Color.Maroon;
            await Task.Delay(100);
            richTextBox5.ForeColor = Color.Maroon;
            await Task.Delay(100);
            richTextBox10.ForeColor = Color.Maroon;
            await Task.Delay(100);
            richTextBox9.ForeColor = Color.Maroon;
            await Task.Delay(100);
            richTextBox8.ForeColor = Color.Maroon;
            await Task.Delay(100);
            richTextBox7.ForeColor = Color.Maroon;
            await Task.Delay(100);
            richTextBox6.ForeColor = Color.Maroon;
            await Task.Delay(400);  // Pause

            // Set all Maroon.
            richTextBox1.ForeColor = Color.Orange;
            await Task.Delay(100);
            richTextBox2.ForeColor = Color.Orange;
            await Task.Delay(100);
            richTextBox3.ForeColor = Color.Orange;
            await Task.Delay(100);
            richTextBox4.ForeColor = Color.Orange;
            await Task.Delay(100);
            richTextBox5.ForeColor = Color.Orange;
            await Task.Delay(100);
            richTextBox10.ForeColor = Color.Orange;
            await Task.Delay(100);
            richTextBox9.ForeColor = Color.Orange;
            await Task.Delay(100);
            richTextBox8.ForeColor = Color.Orange;
            await Task.Delay(100);
            richTextBox7.ForeColor = Color.Orange;
            await Task.Delay(100);
            richTextBox6.ForeColor = Color.Orange;
            await Task.Delay(400);  // Pause

            // Set all Magenta.
            richTextBox1.ForeColor = Color.Magenta;
            await Task.Delay(100);
            richTextBox2.ForeColor = Color.Magenta;
            await Task.Delay(100);
            richTextBox3.ForeColor = Color.Magenta;
            await Task.Delay(100);
            richTextBox4.ForeColor = Color.Magenta;
            await Task.Delay(100);
            richTextBox5.ForeColor = Color.Magenta;
            await Task.Delay(100);
            richTextBox10.ForeColor = Color.Magenta;
            await Task.Delay(100);
            richTextBox9.ForeColor = Color.Magenta;
            await Task.Delay(100);
            richTextBox8.ForeColor = Color.Magenta;
            await Task.Delay(100);
            richTextBox7.ForeColor = Color.Magenta;
            await Task.Delay(100);
            richTextBox6.ForeColor = Color.Magenta;
            await Task.Delay(400);  // Pause

            // Set all Gray.
            richTextBox1.ForeColor = Color.Gray;
            await Task.Delay(100);
            richTextBox2.ForeColor = Color.Gray;
            await Task.Delay(100);
            richTextBox3.ForeColor = Color.Gray;
            await Task.Delay(100);
            richTextBox4.ForeColor = Color.Gray;
            await Task.Delay(100);
            richTextBox5.ForeColor = Color.Gray;
            await Task.Delay(100);
            richTextBox10.ForeColor = Color.Gray;
            await Task.Delay(100);
            richTextBox9.ForeColor = Color.Gray;
            await Task.Delay(100);
            richTextBox8.ForeColor = Color.Gray;
            await Task.Delay(100);
            richTextBox7.ForeColor = Color.Gray;
            await Task.Delay(100);
            richTextBox6.ForeColor = Color.Gray;
            await Task.Delay(400);  // Pause

            // Set all LightGreen.
            richTextBox1.ForeColor = Color.LightGreen;
            await Task.Delay(100);
            richTextBox2.ForeColor = Color.LightGreen;
            await Task.Delay(100);
            richTextBox3.ForeColor = Color.LightGreen;
            await Task.Delay(100);
            richTextBox4.ForeColor = Color.LightGreen;
            await Task.Delay(100);
            richTextBox5.ForeColor = Color.LightGreen;
            await Task.Delay(100);
            richTextBox10.ForeColor = Color.LightGreen;
            await Task.Delay(100);
            richTextBox9.ForeColor = Color.LightGreen;
            await Task.Delay(100);
            richTextBox8.ForeColor = Color.LightGreen;
            await Task.Delay(100);
            richTextBox7.ForeColor = Color.LightGreen;
            await Task.Delay(100);
            richTextBox6.ForeColor = Color.LightGreen;
            await Task.Delay(400);  // Pause

            // Set all different.
            richTextBox1.ForeColor = Color.ForestGreen;
            await Task.Delay(100);
            richTextBox2.ForeColor = Color.Blue;
            await Task.Delay(100);
            richTextBox3.ForeColor = Color.Yellow;
            await Task.Delay(100);
            richTextBox4.ForeColor = Color.Cyan;
            await Task.Delay(100);
            richTextBox5.ForeColor = Color.Orchid;
            await Task.Delay(100);
            richTextBox10.ForeColor = Color.Maroon;
            await Task.Delay(100);
            richTextBox9.ForeColor = Color.Orange;
            await Task.Delay(100);
            richTextBox8.ForeColor = Color.Magenta;
            await Task.Delay(100);
            richTextBox7.ForeColor = Color.Gray;
            await Task.Delay(100);
            richTextBox6.ForeColor = Color.LightGreen;
            await Task.Delay(400);  // Pause


            int x = 1;
            for (x = 1; x < 10; x++) { 

            // Set all different 2.
            richTextBox1.ForeColor = Color.LightGreen;
            richTextBox2.ForeColor = Color.ForestGreen;           
            richTextBox3.ForeColor = Color.Blue;
            richTextBox4.ForeColor = Color.Yellow;            
            richTextBox5.ForeColor = Color.Cyan;            
            richTextBox10.ForeColor = Color.Orchid;            
            richTextBox9.ForeColor = Color.Maroon;            
            richTextBox8.ForeColor = Color.Orange;            
            richTextBox7.ForeColor = Color.Magenta;            
            richTextBox6.ForeColor = Color.Gray;
            await Task.Delay(100);  // Pause

            // Set all different 3.
            richTextBox1.ForeColor = Color.Gray;
            richTextBox2.ForeColor = Color.LightGreen;
            richTextBox3.ForeColor = Color.ForestGreen;
            richTextBox4.ForeColor = Color.Blue;
            richTextBox5.ForeColor = Color.Yellow;
            richTextBox10.ForeColor = Color.Cyan;
            richTextBox9.ForeColor = Color.Orchid;
            richTextBox8.ForeColor = Color.Maroon;
            richTextBox7.ForeColor = Color.Orange;
            richTextBox6.ForeColor = Color.Magenta;
            await Task.Delay(100);  // Pause

            // Set all different 4.
            richTextBox1.ForeColor = Color.Magenta;
            richTextBox2.ForeColor = Color.Gray;
            richTextBox3.ForeColor = Color.LightGreen;
            richTextBox4.ForeColor = Color.ForestGreen;
            richTextBox5.ForeColor = Color.Blue;
            richTextBox10.ForeColor = Color.Yellow;
            richTextBox9.ForeColor = Color.Cyan;
            richTextBox8.ForeColor = Color.Orchid;
            richTextBox7.ForeColor = Color.Maroon;
            richTextBox6.ForeColor = Color.Orange;
            await Task.Delay(100);  // Pause

            // Set all different 5.
            richTextBox1.ForeColor = Color.Orange;
            richTextBox2.ForeColor = Color.Magenta;
            richTextBox3.ForeColor = Color.Gray;
            richTextBox4.ForeColor = Color.LightGreen;
            richTextBox5.ForeColor = Color.ForestGreen;
            richTextBox10.ForeColor = Color.Blue;
            richTextBox9.ForeColor = Color.Yellow;
            richTextBox8.ForeColor = Color.Cyan;
            richTextBox7.ForeColor = Color.Orchid;
            richTextBox6.ForeColor = Color.Maroon;
            await Task.Delay(100);  // Pause

            // Set all different 6.
            richTextBox1.ForeColor = Color.Maroon;
            richTextBox2.ForeColor = Color.Orange;
            richTextBox3.ForeColor = Color.Magenta;
            richTextBox4.ForeColor = Color.Gray;
            richTextBox5.ForeColor = Color.LightGreen;
            richTextBox10.ForeColor = Color.ForestGreen;
            richTextBox9.ForeColor = Color.Blue;
            richTextBox8.ForeColor = Color.Yellow;
            richTextBox7.ForeColor = Color.Cyan;
            richTextBox6.ForeColor = Color.Orchid;
            await Task.Delay(100);  // Pause

            // Set all different 7.
            richTextBox1.ForeColor = Color.Orchid;
            richTextBox2.ForeColor = Color.Maroon;
            richTextBox3.ForeColor = Color.Orange;
            richTextBox4.ForeColor = Color.Magenta;
            richTextBox5.ForeColor = Color.Gray;
            richTextBox10.ForeColor = Color.LightGreen;
            richTextBox9.ForeColor = Color.ForestGreen;
            richTextBox8.ForeColor = Color.Blue;
            richTextBox7.ForeColor = Color.Yellow;
            richTextBox6.ForeColor = Color.Cyan;            
            await Task.Delay(100);  // Pause

            // Set all different 8.
            richTextBox1.ForeColor = Color.Cyan;
            richTextBox2.ForeColor = Color.Orchid;
            richTextBox3.ForeColor = Color.Maroon;
            richTextBox4.ForeColor = Color.Orange;
            richTextBox5.ForeColor = Color.Magenta;
            richTextBox10.ForeColor = Color.Gray;
            richTextBox9.ForeColor = Color.LightGreen;
            richTextBox8.ForeColor = Color.ForestGreen;
            richTextBox7.ForeColor = Color.Blue;
            richTextBox6.ForeColor = Color.Yellow;            
            await Task.Delay(100);  // Pause

            // Set all different 9.
            richTextBox1.ForeColor = Color.Yellow;
            richTextBox2.ForeColor = Color.Cyan;
            richTextBox3.ForeColor = Color.Orchid;
            richTextBox4.ForeColor = Color.Maroon;
            richTextBox5.ForeColor = Color.Orange;
            richTextBox10.ForeColor = Color.Magenta;
            richTextBox9.ForeColor = Color.Gray;
            richTextBox8.ForeColor = Color.LightGreen;
            richTextBox7.ForeColor = Color.ForestGreen;
            richTextBox6.ForeColor = Color.Blue;            
            await Task.Delay(100);  // Pause

            // Set all different 10.
            richTextBox1.ForeColor = Color.Blue;
            richTextBox2.ForeColor = Color.Yellow;
            richTextBox3.ForeColor = Color.Cyan;
            richTextBox4.ForeColor = Color.Orchid;
            richTextBox5.ForeColor = Color.Maroon;
            richTextBox10.ForeColor = Color.Orange;
            richTextBox9.ForeColor = Color.Magenta;
            richTextBox8.ForeColor = Color.Gray;
            richTextBox7.ForeColor = Color.LightGreen;
            richTextBox6.ForeColor = Color.ForestGreen;
            await Task.Delay(100);  // Pause

            // Set all different start.
            richTextBox1.ForeColor = Color.ForestGreen;
            richTextBox2.ForeColor = Color.Blue;
            richTextBox3.ForeColor = Color.Yellow;
            richTextBox4.ForeColor = Color.Cyan;
            richTextBox5.ForeColor = Color.Orchid;
            richTextBox10.ForeColor = Color.Maroon;
            richTextBox9.ForeColor = Color.Orange;
            richTextBox8.ForeColor = Color.Magenta;
            richTextBox7.ForeColor = Color.Gray;
            richTextBox6.ForeColor = Color.LightGreen;
            await Task.Delay(100);  // Pause

            }  // for

            // Set all Red.
            richTextBox1.ForeColor = Color.Red;
            await Task.Delay(100);
            richTextBox2.ForeColor = Color.Red;
            await Task.Delay(100);
            richTextBox3.ForeColor = Color.Red;
            await Task.Delay(100);
            richTextBox4.ForeColor = Color.Red;
            await Task.Delay(100);
            richTextBox5.ForeColor = Color.Red;
            await Task.Delay(100);
            richTextBox10.ForeColor = Color.Red;
            await Task.Delay(100);
            richTextBox9.ForeColor = Color.Red;
            await Task.Delay(100);
            richTextBox8.ForeColor = Color.Red;
            await Task.Delay(100);
            richTextBox7.ForeColor = Color.Red;
            await Task.Delay(100);
            richTextBox6.ForeColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
