﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class FormEnter : Form
    {
        public FormEnter()
        {
            InitializeComponent();
        }

        private void buttonTasks_Click(object sender, EventArgs e)
        {
            var form = new FormTasks();
            form.ShowDialog();
        }

        private void buttonNotes_Click(object sender, EventArgs e)
        {
            var form = new FormNotes();
            form.ShowDialog();
        }
    }
}
