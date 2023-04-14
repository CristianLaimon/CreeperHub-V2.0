namespace responsivecolorproject
{
    public partial class Form1 : Form
    {
        //Fields
        Random random;
        byte index;
        Button currentButton;

        public Form1()
        {
            InitializeComponent();
            random = new();
        }

        private Color ChooseColor()
        {
            byte tempIndex = (byte)random.Next(ThemeColor.ColorsList.Count);
            string colorString = ThemeColor.ColorsList[tempIndex];
            Color newColor = ColorTranslator.FromHtml(colorString);
            return newColor;
        }

        private void HighLight(Button button)
        {
            if ( button != null )
            {
                if(currentButton != button)
                {
                    button.BackColor = 6, 64, 34;


                    currentButton = button;
                }
            }
        }
    }
}