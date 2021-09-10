using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KbalaGS
{
    public partial class PhotoProduit : Form
    {
        private byte[] image;
        public PhotoProduit(byte[] image)
        {
            InitializeComponent();
            this.image = image;
        }

        private void PhotoProduit_Load(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(this.image);
            pictureProduit.Image = new Bitmap(ms);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
