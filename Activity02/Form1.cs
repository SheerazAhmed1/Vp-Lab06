using Timer = System.Windows.Forms.Timer;

namespace Activity02
{
    public partial class Form1 : Form
    {
       Timer myTimer=new Timer();
        Form2 obj = new Form2();
        public bool timerstoped=false;
        public Form1()
        {
            InitializeComponent();
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            myTimer.Interval = 1000;
            myTimer.Start();
            myTimer.Tick += MyTimer_Tick;
        }

        private void MyTimer_Tick(object? sender, EventArgs e)
        {
            if (this.progressBar1.Value == 100)
            {
               this.Visible = false;
                if (obj.Visible == false) { obj.ShowDialog(); }
                myTimer.Stop();

            }

            else
            {
                this.progressBar1.Value += 10;
            }

        }

        
    }
}