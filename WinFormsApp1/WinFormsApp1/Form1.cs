namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Settings settingsexp;
        private Settings settingsexp_2;

        public Form1()
        {
            InitializeComponent();

            settingsexp = Settings.GetInstance();
            settingsexp_2 = Settings.GetInstance();
            appnametextbox.Text = settingsexp.appname;
            appversiontextbox.Text = settingsexp.appversion;
            textBox1.Text = "App Name: " + settingsexp.appname + Environment.NewLine + "App Version: " + settingsexp.appversion;
            textBox2.Text = "App Name: " + settingsexp_2.appname + Environment.NewLine + "App Version: " + settingsexp_2.appversion;
            updatebtn.Click += updatebtn_Click;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            settingsexp.appname = appnametextbox.Text;
            settingsexp.appversion = appversiontextbox.Text;

            textBox1.Text = "App Name: " + settingsexp.appname + Environment.NewLine + "App Version: " + settingsexp.appversion;
            textBox2.Text = "App Name: " + settingsexp_2.appname + Environment.NewLine + "App Version: " + settingsexp_2.appversion;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Settings
    {
        private static Settings instance;
        public string appname { get; set; }
        public string appversion { get; set; }

        private Settings()
        {
            appname = "TestApp";
            appversion = "1.0";
        }

        public static Settings GetInstance()
        {
            if (instance == null)
            {
                instance = new Settings();
            }
            return instance;
        }
    }
}
