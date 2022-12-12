namespace Activity04
{
    public partial class Form1 : Form
    {
        public string[] mystudents;
        public int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (mystudents.Length < count)
            {
                mystudents = new string[mystudents.Length + 1];
                mystudents[count-1]=stdName.Text.ToString();
            }

            for(int i = 0; i < mystudents.Length; i++)
            {
                label1.Text= mystudents[i].ToString()+"\n";
            }
        }
    }

    public class studentClass
    {

        public string firstName;

    }
}