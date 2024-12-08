using Guna.Charts.WinForms;
using System.Drawing;

namespace QLKS
{
    internal class GunaChartDataPoint : LPoint
    {
        public GunaChartDataPoint(string label, double y) : base(label, y)
        {
        }

        public Color BackgroundColor { get; internal set; }
    }
}