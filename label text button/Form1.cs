using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace label_text_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.ToString();
            label1.Visible = true; /*Metin kısmımızı uygulama açıldığında görünmesini istemiyorsak
                                     bunu formumuzun design kısmından gizliyoruz ardından butona
                                     basıldığında görünürlüğünü aktif hale getiriyoruz ki metin
                                     kutusuna yazdıklarımız ekranda görünür hale gelebilsin*/ 
        }

       
    }
}
