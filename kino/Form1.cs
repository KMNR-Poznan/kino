using System.Drawing;

namespace kino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void InitializeMyButton(int a)
        {
            Button button = new Button();
            button.DialogResult = DialogResult.OK;
            Controls.Add(button);
            button.Click += button150;
            button.Text = "Godzina " + a;
            button.Location = new Point(12, 70);
        }

        private void sala(int a)
        {
            
            CheckBox checkBox = new CheckBox(); 

            Controls.Add(checkBox);
            
            checkBox.Text = "";
            checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox.Image = new Bitmap(@"C:\Users\Norbert\Desktop\krzeslo1.png", true); 
            checkBox.Location = new Point(90+a, 90);
            checkBox.Size = new Size(60, 60);
        }
   
        private void button150(object sender, EventArgs e)
        {
            for (int i = 0; i < 700; i+=70)
            {
                sala(i);

            }
        }

        private void dniTygodnia(object sender, EventArgs e)
        {

            InitializeMyButton(0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}