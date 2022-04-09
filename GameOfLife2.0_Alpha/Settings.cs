using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife2._0_Alpha
{
    public partial class Settings : Form
    {
        private int scrollRes, scrollDen;
        public Settings()
        {
            InitializeComponent();
            tbResolution.Value = 10;
            tbDensity.Value = 2;
            rbAuto.Checked = true;
            rbDraw.Checked = false;
            Data.rbAutoData = rbAuto.Checked;
            Data.rbDrawData = rbDraw.Checked;
            scrollRes = (int)tbResolution.Value;
            scrollDen = (int)tbDensity.Value;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
            base.OnFormClosing(e);
        }

        private void tbResolution_Scroll(object sender, EventArgs e)
        {
            scrollRes = (int)tbResolution.Value;
        }

        private void tbDensity_Scroll(object sender, EventArgs e)
        {
            scrollDen = (int)tbDensity.Value;
        }

        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            Data.rbAutoData = rbAuto.Checked;
        }

        private void rbDraw_CheckedChanged(object sender, EventArgs e)
        {
            Data.rbDrawData = rbDraw.Checked;
        }

        public void bApply_Click(object sender, EventArgs e)
        {
            Data.resolutionData = scrollRes;
            Data.densityData = scrollDen;
            Hide();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            tbResolution.Value = 10;
            tbDensity.Value = 2;
            rbAuto.Checked = true;
            rbDraw.Checked = false;
            Data.rbAutoData = rbAuto.Checked;
            Data.rbDrawData = rbDraw.Checked;
            Data.resolutionData = scrollRes;
            Data.densityData = scrollDen;
            Hide();
        }
    }
}
