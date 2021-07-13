using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.Json;

namespace Semester_Proj
{
    
    public class EventTest{
        public string eventName { get; set; }
        public string day { get; set; }
    }
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        //public static string Serialize (object? value, Type inputType, System.Text.Json.JsonSerializerOptions? options = default);
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyWindow());
            //public static string Serialize<T> (T value, JsonSerializerOptions? options = default);
            
            //string jsonString = JsonSerializer.Serialize(EventTest);

            //Console.WriteLine(jsonString);
            
        }
    }
    class MyWindow : Form1{
        
        Pen pen = new Pen(Color.Black, 5);
        const int SQUARE = 100, MARGIN = 50;
        public static int month_number = 0;
        public MyWindow() {
            Text = "CalTest";
            ClientSize = new Size(900, 700);
            BackColor = Color.White;
            StartPosition = FormStartPosition.CenterScreen;
            button1.Click += button1_Click;
            //textBox1.Text += textBox1_KeyDown;
            //button1.Click += new EventHandler(button1_Click);
            textBox1.Text += new EventHandler(textBox1_KeyDown);
            //Popup.textBox1.Text +=
        }
        Point map(int x, int y) =>
        new Point(MARGIN + x * SQUARE, MARGIN + y * SQUARE);

        void line(Graphics g, int from_x, int from_y, int to_x, int to_y) {
            g.DrawLine(pen, map(from_x, from_y), map(to_x, to_y));
        }
        protected override void OnPaint(PaintEventArgs args) {
            Graphics g = args.Graphics;
            
            for (int x = 1 ; x <= 5 ; ++x) {
                line(g, 0, x, 7, x);
            }

            for (int x = 0 ; x <= 7 ; ++x) {
                line(g, x, 1, x, 5);
            }
        }
        protected override void OnMouseDown(MouseEventArgs args) {
            int x = ((int) (args.X - MARGIN)) / SQUARE;
            int y = ((int) (args.Y - MARGIN)) / SQUARE;
            Console.WriteLine($"user clicked square {x}, {y}");
            Console.WriteLine("hey");
            
        }
        private void button1_Click(object sender, EventArgs e) // try in from1
        {   
                var formPopup = new Popup();
                formPopup.Show(this);
                Console.WriteLine("hey");
        }
        public void textBox1_KeyDown(object sender, KeyEventArgs e){
            string var;
            var = textBox1.Text;
        }
        // public void label1_Click(object sender, EventArgs e)
        // {
        //     var formPopup = new Popup();
        //     formPopup.Show(this);
        // }
    }
}
