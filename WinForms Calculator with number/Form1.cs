namespace WinForms_Calculator_with_number
{
    public partial class Form1 : Form

    {
        char simbol;
        bool cleanDisplay;
        int oneNumber;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            cleanDisplay = true;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text = btn.Text;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn_twicezero_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;

            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            cleanDisplay=true;
        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            simbol = '/';
            cleanDisplay = true;
            oneNumber = Convert.ToInt32(label1.Text);
            Button btn = (Button)sender;
            label1.Text = btn.Text;
        }

        private void btn_vurma_Click(object sender, EventArgs e)
        {
            simbol = '*';
            cleanDisplay = true;
            oneNumber = Convert.ToInt32(label1.Text);
            Button btn = (Button)sender;
            label1.Text = btn.Text;
        }

        private void btn_toplama_Click(object sender, EventArgs e)
        {
            simbol = '+';
            cleanDisplay = true;
            oneNumber = Convert.ToInt32(label1.Text);
            Button btn = (Button)sender;
            label1.Text = btn.Text;
        }

        private void btn_cixma_Click(object sender, EventArgs e)
        {
            simbol = '-';
            cleanDisplay = true;
            oneNumber = Convert.ToInt32(label1.Text);
            Button btn = (Button)sender;
            label1.Text = btn.Text;
        }

        private void btn_noqte_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            label1.Text = btn.Text;
        }

        private void btn_beraber_Click(object sender, EventArgs e)
        {
            int twonumber = Convert.ToInt32(label1.Text);
            int total;

            switch (simbol)
            {
                case '+':
                    total = oneNumber+twonumber; 
                    break;


                case '-':
                    total = oneNumber - twonumber;
                    break;


                case '*':
                    total = oneNumber * twonumber;
                    break;


                case '/':
                    total = oneNumber / twonumber;
                    break;
                      
                    default: total = 0; 
                    break;
            }
            label1.Text = total.ToString(); 
        }
    }
}
