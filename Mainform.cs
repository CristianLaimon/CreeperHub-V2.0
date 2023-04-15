using System.Drawing.Design;
using responsivecolorproject.KLibrarys;

namespace responsivecolorproject
{
    public partial class Mainform : Form
    {
        Random random;
        Button currentButton;
        static byte index;
        byte tempIndex;
        Form currentForm;

        public Mainform()
        {
            InitializeComponent();
            random = new();
            currentButton = new Button();
            currentForm = new Form();
        }

        private void HighLight(Object button, bool hide) //hide es para si se quiere quitar el color de los botones pulsados antes y solo se coloree el que se pulsa. False para que los colores no se borren y se conserven
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
                currentButton.Font = new Font("Segoe UI", 11.8F, FontStyle.Bold, GraphicsUnit.Point);
                panelHeader.BackColor = ThemeColor.ColorsList[index];
                panelLogo.BackColor = Klibrary.ChangeColorBrightness(ThemeColor.ColorsList[index], -0.1);
            }
        }


        private void UnHighLight()
        {
            foreach (Control control in panelMenu.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.BackColor = Color.FromArgb((byte)(35), (byte)(41), (byte)(47));
                    control.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        public void OpenChildForm(Form child)
        {
            currentForm.Close();
            currentForm = child;

            child.FormBorderStyle = FormBorderStyle.None;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;

            panelChild.Controls.Add(child);

            child.BringToFront();
            child.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HighLight(sender, true);
            OpenChildForm(new Mainform());
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