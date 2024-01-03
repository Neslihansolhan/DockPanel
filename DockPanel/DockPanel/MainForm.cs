using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using DockPanel.dockPanels;

namespace DockPanel
{
    public partial class MainForm : Form
    {   
        Form1 form1;
        Form2 form2;
        Form3 form3;
        Form4 form4;
        Form5 form5;
        Form6 form6;
        Form7 form7;
        Form8 form8;
        Form9 form9;
        Form10 form10;
        Form11 form11;

        public MainForm()
        {
            InitializeComponent();

            form1 = new Form1();
            form2 = new Form2();
            form3 = new Form3();
            form4 = new Form4();
            form5 = new Form5();
            form6 = new Form6();
            form7 = new Form7();
            form8 = new Form8();
            form9 = new Form9();
            form10 = new Form10();
            form11 = new Form11();

            form1.Show(dockPanel1, DockState.DockLeft);

            Control ctrl = dockPanel3;
            ctrl.Dock = DockStyle.Fill;

            form2.Controls.Add(ctrl);
            form2.Show(dockPanel1, DockState.DockLeft);
            //form2.Show(form1.Pane, DockAlignment.Bottom,0.75);

            form3.Show(dockPanel1, DockState.Document);

            ctrl = dockPanel2;
            ctrl.Dock = DockStyle.Fill;

            form4.Controls.Add(ctrl);
            form4.Show(form3.Pane, DockAlignment.Bottom, 0.75);

            dockPanel1.DockLeftPortion = 0.5;

            form5.Show(dockPanel2, DockState.Document);
            form6.Show(dockPanel2, DockState.Document);
            form7.Show(dockPanel2, DockState.Document);
            form8.Show(dockPanel2, DockState.Document);

            form9.Show(dockPanel3, DockState.Document);
            form10.Show(dockPanel3, DockState.Document);
            form11.Show(dockPanel3, DockState.Document);
        }
    }
}
