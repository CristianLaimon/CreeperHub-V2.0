namespace responsivecolorproject
{
    public partial class Form1 : Form
    {
        //Fields
        Random random;
        Button currentButton;
        byte index, tempIndex;

        public Form1()
        {
            InitializeComponent();
            random = new();
        }

        //private Color ChooseColor()
        //{
        //    byte tempIndex = (byte)random.Next(ThemeColor.ColorsList.Count);
        //    string colorString = ThemeColor.ColorsList[tempIndex];
        //    Color newColor = ColorTranslator.FromHtml(colorString);
        //    return newColor;
        //}

        private void HighLight(Object button)
        {

            if(currentButton != (Button)button)
            {
                UnHighLight();
                currentButton = (Button)button;
                tempIndex = (byte)random.Next(ThemeColor.ColorsList.Count);
                while(tempIndex == index)
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
            foreach(Control control in panelMenu.Controls)
            {
                if(control.GetType() == typeof(Button))
                {
                    control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
                    control.Font = new Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HighLight(sender);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            HighLight(sender);

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            HighLight(sender);

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            HighLight(sender);

        }

        private void buttonCredits_Click(object sender, EventArgs e)
        {
            HighLight(sender);

        }
    }
}