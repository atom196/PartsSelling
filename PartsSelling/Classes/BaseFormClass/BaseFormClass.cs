using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartsSelling.Classes
{
    public class BaseFormClass : Form
    {
        // movable
        private bool mouseDown;
        private Point lastLocation;

        // rounded edges
        // https://learn.microsoft.com/ru-ru/windows/apps/desktop/modernize/apply-rounded-corners

        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33
        }

        public enum DWM_WINDOW_CORNER_PREFERENCE
        {
            DWMWCP_DEFAULT = 0,
            DWMWCP_DONOTROUND = 1,
            DWMWCP_ROUND = 2,
            DWMWCP_ROUNDSMALL = 3
        }

        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        protected static extern void DwmSetWindowAttribute(IntPtr hwnd,
            DWMWINDOWATTRIBUTE attribute,
            ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute,
            uint cbAttribute);

        public BaseFormClass()
        {
            // Set rounded corners
            var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
            var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
            DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));

            //set bordless form movable
            this.MouseDown += MovableBorderlessForm_MouseDown;
            this.MouseMove += MovableBorderlessForm_MouseMove;
            this.MouseUp += MovableBorderlessForm_MouseUp;
        }

        private void MovableBorderlessForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MovableBorderlessForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MovableBorderlessForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseFormClass
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BaseFormClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }
    }
}
