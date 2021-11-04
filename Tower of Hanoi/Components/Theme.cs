using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Components
{
    public static class Theme
    {
        public static Color Primary { get; } = Color.FromArgb(0, 102, 139);
        public static Color OnPrimary { get; } = Color.FromArgb(255, 255, 255);
        public static Color Secondary { get; } = Color.FromArgb(78, 97, 109);
        public static Color OnSecondary { get; } = Color.FromArgb(255, 255, 255);
        public static Color Tertiary { get; } = Color.FromArgb(172, 51, 5);
        public static Color OnTertiary { get; } = Color.FromArgb(255, 255, 255);

        public static Color Background { get; } = Color.FromArgb(251, 252, 255);
        public static Color OnBackground { get; } = Color.FromArgb(25, 28, 30);

        public static Color[] DiskColors { get; } =
        {
            Color.FromArgb(2, 119, 189),
            Color.FromArgb(3, 155, 229),
            Color.FromArgb(41, 182, 246),
            Color.FromArgb(129, 212, 250)
        };
    }
}
