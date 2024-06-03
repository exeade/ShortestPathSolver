using System;
using System.Windows.Forms;

namespace ShortestPathSolver
{
    interface IWindow
    {
        void TopPanel_MouseDown(object sender, MouseEventArgs e);
        void TopPanel_MouseMove(object sender, MouseEventArgs e);
        void ButtonToExit_Click(object sender, EventArgs e);
    }
}
