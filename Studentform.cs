using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MultiFaceRec
{
    public partial class Studentform : Form
    {
        public Studentform()
        {
            InitializeComponent();
            loadformpv(new FrmMainForm());
            Panelnav.Height = Studentattendencedashbtn.Height;
            Panelnav.Top = Studentattendencedashbtn.Top;
            Panelnav.Left = Studentattendencedashbtn.Left;
      
            
            Studentattendencedashbtn.BackColor = Color.FromArgb(46, 51, 73);
        }


  private void Studentattendencedashbtn_Click(object sender, EventArgs e)
        {
                loadformpv(new FrmMainForm());
                Panelnav.Height = Studentattendencedashbtn.Height;
                Panelnav.Top = Studentattendencedashbtn.Top;
                Panelnav.Left = Studentattendencedashbtn.Left;
                Studentattendencedashbtn.BackColor = Color.FromArgb(46, 51, 73);
            
        }

                public void loadformpv(object Form)
                {
                    if (this.panelteachermain.Controls.Count > 0)
                        this.panelteachermain.Controls.RemoveAt(0);
                    Form forminpv = Form as Form;
                    forminpv.TopLevel = false;
                    forminpv.Dock = DockStyle.Fill;
                    this.panelteachermain.Controls.Add(forminpv);
                    this.panelteachermain.Tag = forminpv;
                    forminpv.Show();
                }

        private void Studentattendencedashbtn_Leave(object sender, EventArgs e)
        {
            Studentattendencedashbtn.BackColor = Color.FromArgb(24, 30, 54);
        }
    }



    }

    
      

    

