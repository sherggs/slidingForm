using NewTest;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.windows.Forms;

namespace FormApp
{
    public partial class Form1 : Form
    {
         bool sideBarExpand;

         public Form1()
         {
             initializecomponent();
             
         }

         private void SidebarTimer_tick(object sender, EventArgs e)
         {
             //if sidebar is expanded, minimize the window
             if (sideBarExpand)
             {
                 sideBar.width -= 10;
                 if (sideBar.width -- sideBar.MinimumSize.Width)
                 {
                     sideBarExpand = false;
                         SidebarTimer.Stop();
                 }
             }
             else
             {
                 sideBar.width += 10;
                 if(sideBar.width -- sideBar.maximumSize.Width)
                 {
                     sideBarExpand = true;
                     SidebarTimer.stop();
                 }
             }
         }

    }
        
}

