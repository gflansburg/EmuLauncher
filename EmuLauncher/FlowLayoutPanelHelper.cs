using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmuLauncher
{ 
    public static class FlowLayoutPanelHelper
    {
        public static int GetFlowHeight(this FlowLayoutPanel flowPanel)
        {
            if (flowPanel.Controls.Count == 0)
            {
                return 0;
            }
            return ((flowPanel.Controls[0].Height + flowPanel.Controls[0].Margin.Top + flowPanel.Controls[0].Margin.Bottom) * flowPanel.GetRowCount()) + flowPanel.Padding.Top + flowPanel.Padding.Bottom;
        }

        public static int GetRowCount(this FlowLayoutPanel flowPanel)
        {
            if (flowPanel.Controls.Count == 0)
            {
                return 0;
            }
            int cols = flowPanel.GetColumnCount();
            int rows = flowPanel.Controls.Count / cols;
            if (flowPanel.Controls.Count % cols != 0)
            {
                rows += 1;
            }
            return rows;
        }

        public static int GetColumnCount(this FlowLayoutPanel flowPanel)
        {
            if (flowPanel.Controls.Count == 0)
            {
                return 0;
            }
            return (flowPanel.ClientRectangle.Width - flowPanel.Padding.Left - flowPanel.Padding.Right) / (flowPanel.Controls[0].Width + flowPanel.Controls[0].Margin.Left + flowPanel.Controls[0].Margin.Right);
        }
    }
}
