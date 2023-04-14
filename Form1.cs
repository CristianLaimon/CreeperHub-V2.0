using System.Drawing.Design;

namespace responsivecolorproject
{
    public partial class Form1 : Form
    {
        Random random;
        Button currentButton;
        byte index, tempIndex;
        List<Button> botonesMenu;
        bool rainbowMode;


        public Form1()
        {
            InitializeComponent();
            random = new();
            botonesMenu = new List<Button> { buttonHome, buttonUsers, buttonSettings, buttonHelp, buttonCredits };
            currentButton = new Button();
        }

        private void HighLight(Object button, bool hide)
        {
            if (currentButton != (Button)button)
            {
                if(hide) { UnHighLight(); }
                currentButton = (Button)button;
                tempIndex = (byte)random.Next(ThemeColor.ColorsList.Count);
                while (tempIndex == index)
                {
                    tempIndex = (byte)random.Next(ThemeColor.ColorsList.Count);
                }
                index = tempIndex;
                currentButton.BackColor = ThemeColor.ColorsList[index];
                currentButton.Font = new Font("Segoe UI", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            }
        }


        private void UnHighLight()
        {
            foreach (Control control in panelMenu.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
                    control.Font = new Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HighLight(sender, true);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            HighLight(sender, true);


        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            HighLight(sender, true);


        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            HighLight(sender, true);


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            rainbowMode = !rainbowMode;

            if (rainbowMode)
            { 
                pictureBox1.Image = Properties.Resources.R; 
            } 
            else 
            { 
                pictureBox1.Image = Properties.Resources.X; 
            }

            while(rainbowMode)
            {
                foreach (Button button in botonesMenu)
                {
                    HighLight(button, true);
                    await Task.Delay(500);
                }
            }
        }

        private async void buttonRainbow2_Click(object sender, EventArgs e)
        {
            rainbowMode = !rainbowMode;

            if (rainbowMode)
            {
                pictureBox1.Image = Properties.Resources.R;  //le puse r porque  si, no hay mas misterio
            }
            else
            {
                pictureBox1.Image = Properties.Resources.X;
            }

            while (rainbowMode)
            {
                foreach (Button button in botonesMenu)
                {
                    HighLight(button, false);
                    await Task.Delay(500);
                }
            }
        }

        private void buttonCredits_Click(object sender, EventArgs e)
        {
            HighLight(sender, true);

        }
    }
}