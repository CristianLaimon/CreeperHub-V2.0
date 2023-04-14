using System.Drawing.Design;

namespace responsivecolorproject
{
    public partial class Form1 : Form
    {
        Random random;
        Button currentButton;
        static byte index;
        byte tempIndex;
        public Form1()
        {
            InitializeComponent();
            random = new();
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

        private void buttonCredits_Click(object sender, EventArgs e)
        {
            HighLight(sender, true);
        }
    }
}