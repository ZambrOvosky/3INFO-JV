﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenatinhaPlace.Forms
{
    public partial class ucCashierHome : UserControl
    {
        public ucCashierHome()
        {
            InitializeComponent();
        }

        private void ucCashierHome_Load(object sender, EventArgs e)
        {
            lblEnterAccount.Text = Strings.Enter_Account;
            btnSearch.Text = Strings.Search;
        }

        //SIZE TELA TODA: 1321; 655
    }
}