using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace ekolayzer
{
    
    public partial class frm_eko : Form
    {
        public frm_eko()
        {
            InitializeComponent();
        }
        SoundPlayer player=new SoundPlayer();
 Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Height =random.Next(150);
            panel2.Height = random.Next(150);
            panel3.Height = random.Next(150);
            panel4.Height = random.Next(150);
            panel5.Height = random.Next(150);
            panel6.Height = random.Next(150);
            panel7.Height = random.Next(150);
            panel8.Height = random.Next(150);
        }
       
        private void frm_eko_Load(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\MONSTER\Downloads\Kar-Gördüm-Kaydım-_REMIX_2016-2017-MAHMUT-TUNCER....wav";
            player.Play();
            timer1.Start();
            this.BackColor = Color.Black;
        }
    }
}
