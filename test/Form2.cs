using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace test
{
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MaterialSkinManager mng = MaterialSkinManager.Instance;
            mng.AddFormToManage(this);
            mng.Theme = MaterialSkinManager.Themes.LIGHT;
            mng.ColorScheme = new ColorScheme(Primary.Yellow600, Primary.LightBlue300, Primary.Pink600, Accent.Cyan700, TextShade.BLACK);
        }
    }
}
