﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Kayıt
{
    public partial class Frm_Raporlar : Form
    {
        public Frm_Raporlar()
        {
            InitializeComponent();
        }

        private void Frm_Raporlar_Load(object sender, EventArgs e)
        {
            
            this.tbl_PersonelTableAdapter.Fill(this.personelProjeDataSet1.Tbl_Personel);

            this.reportViewer1.RefreshReport();
            
        }

        
    }
}
