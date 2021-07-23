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
        string[] months = {"January","Febuary","March","April","May","June","July","August","September","October","November","December"};
        int[] number_of_days = {31,28,31,30,31,30,31,31,30,31,30,31};
        int[] first_day = {4,0,0,3,5,1,3,6,2,4,0,2};
        
        int month_index = 0;
        const int SQUARE = 100, MARGIN = 50;
        public static int month_number = 0; // jan first month
         SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(128, 0, 0, 255));
            Font drawFont = new Font("Arial", 16);
        public MyWindow() {
            Text = "CalTest";
            ClientSize = new Size(900, 700);
            BackColor = Color.White;
            SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(128, 0, 0, 255));
            Font drawFont = new Font("Arial", 16);
            StartPosition = FormStartPosition.CenterScreen;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            update_month();

            //textBox1.Text += textBox1_KeyDown;
            //button1.Click += new EventHandler(button1_Click);
            //textBox1.Text += new EventHandler(textBox1_KeyDown);
            //Popup.textBox1.Text +=
        }
        Point map(int x, int y) =>
        new Point(MARGIN + x * SQUARE, MARGIN + y * SQUARE);

        void line(Graphics g, int from_x, int from_y, int to_x, int to_y) {
            g.DrawLine(pen, map(from_x, from_y), map(to_x, to_y));
        }
        protected override void OnPaint(PaintEventArgs args) {
            Graphics g = args.Graphics;
            
            for (int x = 1 ; x <= 6 ; ++x) {
                line(g, 0, x, 7, x);
            }

            for (int x = 0 ; x <= 7 ; ++x) {
                line(g, x, 1, x, 6);
            }
        }
        protected override void OnMouseDown(MouseEventArgs args) {
            int x = ((int) (args.X - MARGIN)) / SQUARE;
            int y = ((int) (args.Y - MARGIN)) / SQUARE;
            Console.WriteLine($"user clicked square {x}, {y}");
            //Console.WriteLine("hey");
            // if(x == 0 && y == 0){
            //     var formPopup = new Popup();
            //     formPopup.Show(this);
            // }
        }
        private void button1_Click(object sender, EventArgs e) // try in from1
        {   
                var formPopup = new Popup();
                formPopup.Show(this);
        }
        private void button2_Click(object sender, EventArgs e) // previous 
        {   if(month_number == 0){
                month_number = 11;
            }   
            else{
                month_number = (month_number - 1) % 11;
            }
            update_month();
        }
        private void button3_Click(object sender, EventArgs e) // next 
        {   
            month_number = (month_number + 1) % 11;
            update_month();
        }

        
        private void update_month(){
            var labels = new List<Label> { label8, label9, label10,label11,label12,label13,label14 ,label15 ,label16 ,label17 ,label18 ,label19 ,label20 ,label21 ,label22
            ,label23 ,label24 ,label25 ,label26 ,label27 ,label28 ,label29 ,label30 ,label31 ,label32 ,label33 ,label34 ,label35 ,label36 ,label37 ,label38 ,label39 ,label40
            ,label41 ,label42};
            foreach (var label in labels)  
            {  
                label.Text = "";  
            }
            
            int day = 1;
            switch(month_number){
                case 0:
                this.Month.Text = months[month_number];
                // var jan = labels.RemoveRange(1,5);
                foreach (var label in labels.Skip(4))  
                {   
                    label.Text = day.ToString();
                    if(number_of_days[month_number] == day){
                        Invalidate();
                        break;
                    }  
                    day++;
 
                }
                Invalidate();
                break;

                case 1:
                this.Month.Text = months[month_number];
                foreach (var label in labels)  {   
                    label.Text = day.ToString();
                    if(number_of_days[month_number] == day){
                        Invalidate();
                        break;
                    }  
                    day++;
                }
                Invalidate();
                break;

                case 2:
                this.Month.Text = months[month_number];
                foreach (var label in labels)  {   
                    label.Text = day.ToString();
                    if(number_of_days[month_number] == day){
                        Invalidate();
                        break;
                    }  
                    day++;
                }
                Invalidate();
                break;

                case 3:
                this.Month.Text = months[month_number];
                foreach (var label in labels.Skip(3))  {   
                    label.Text = day.ToString();
                    if(number_of_days[month_number] == day){
                        Invalidate();
                        break;
                    }  
                    day++;
                }
                Invalidate();
                break;

                case 4:
                this.Month.Text = months[month_number];
                foreach (var label in labels.Skip(5))  {   
                    label.Text = day.ToString();
                    if(number_of_days[month_number] == day){
                        Invalidate();
                        break;
                    }  
                    day++;
                }
                Invalidate();
                break;

                case 5:
                this.Month.Text = months[month_number];
                foreach (var label in labels.Skip(1))  {   
                    label.Text = day.ToString();
                    if(number_of_days[month_number] == day){
                        Invalidate();
                        break;
                    }  
                    day++;
                }
                Invalidate();
                break;

                case 6:
                this.Month.Text = months[month_number];
                foreach (var label in labels.Skip(3))  {   
                    label.Text = day.ToString();
                    if(number_of_days[month_number] == day){
                        Invalidate();
                        break;
                    }  
                    day++;
                }
                Invalidate();

                break;

                case 7:
                this.Month.Text = months[month_number];
                foreach (var label in labels.Skip(6))  {   
                    label.Text = day.ToString();
                    if(number_of_days[month_number] == day){
                        Invalidate();
                        break;
                    }  
                    day++;
                }
                Invalidate();
                break;
                
                case 8:
                this.Month.Text = months[month_number];
                foreach (var label in labels.Skip(2))  {   
                    label.Text = day.ToString();
                    if(number_of_days[month_number] == day){
                        Invalidate();
                        break;
                    }  
                    day++;
                }
                Invalidate();
                break;

                case 9:
                this.Month.Text = months[month_number];
                foreach (var label in labels.Skip(4))  {   
                    label.Text = day.ToString();
                    if(number_of_days[month_number] == day){
                        Invalidate();
                        break;
                    }  
                    day++;
                }
                Invalidate();
                break;

                case 10:
                this.Month.Text = months[month_number];
                foreach (var label in labels)  {   
                    label.Text = day.ToString();
                    if(number_of_days[month_number] == day){
                        Invalidate();
                        break;
                    }  
                    day++;
                }
                Invalidate();
                break;

                case 11:
                this.Month.Text = months[month_number];
                foreach (var label in labels.Skip(2))  {   
                    label.Text = day.ToString();
                    if(number_of_days[month_number] == day){
                        Invalidate();
                        break;
                    }  
                    day++;
                }
                Invalidate();
                break;
            }
        }
        // public void textBox1_KeyDown(object sender, KeyEventArgs e){
        //     string var;
        //     var = textBox1.Text;
        // }
        // public void label1_Click(object sender, EventArgs e)
        // {
        //     var formPopup = new Popup();
        //     formPopup.Show(this);
        // }
    }
}
