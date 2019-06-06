using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace cbattery
{
    /// <summary>
    /// IconManager is for saving all information about Icon to display
    /// This class designed to provide final result to Form 
    /// </summary>
    [Serializable]
    public class IconManager
    {
        public List<ColorStintData> Stints { get; }

        public IconManager()
        {
            Stints = new List<ColorStintData>();
        }

        public static IconManager New()
        {
            var im = new IconManager();
            im.AddStint();
            return im;
        }

        /// <summary>
        /// Add default stint
        /// </summary>
        /// <returns></returns>
        public void AddStint()
        {
            AddStint(Color.White, Color.White, 1);
        }

        /// <summary>
        /// Add stint
        /// </summary>
        /// <param name="color">Color of stint</param>
        /// <param name="textColor"></param>
        /// <param name="percent">Lowest percent of stint</param>
        /// <returns>True if added, else false</returns>
        public void AddStint(Color color, Color textColor, int percent)
        {
            var t = new ColorStintData()
            {
                Color = color,
                Percent = percent,
                TextColor = textColor
            };

            Stints.Add(t);
            Stints.Sort();
        }

        public void ChangeStintByIndex(int index, int percent)
        {
            Stints[index].Percent = percent;
            Stints.Sort();
        }
        
        public void ChangeStintByIndex(int index, Color color)
        {
            Stints[index].Color = color;
            Stints.Sort();
        }

        public void RemoveStint(int index)
        {
            Stints.RemoveAt(index);
            Stints.Sort();
        }
        
        public Icon GetIconByPercent(int percent)
        {
            var colorStint = GetColorStintByPercent(percent);
            if (!colorStint.Equals(null))
            {
                var iconBuilder = new IconBuilder();
                var percentStr = percent == 100 ? "F" : percent.ToString("00");
                iconBuilder.SetString(colorStint.TextColor, percentStr, IconBuilderTextSizes.Double);
                iconBuilder.SetBottomColor(colorStint.Color);
                return iconBuilder.Build();
            }
            else
            {
                throw new FormatException();
            }
        }

        private ColorStintData GetColorStintByPercent(int percent)
        {
            if (percent >= Stints[0].Percent)
                return Stints[0];
            
            for (int i = 1; i < Stints.Count; ++i)
            {
                if (Stints[i - 1].Percent > percent && percent >= Stints[i].Percent)
                    return Stints[i];
            }

            return Stints.Last();
        }
    }


    /// <summary>
    /// Struct to store info about battery percentage stint
    /// </summary>
    [Serializable]
    public class ColorStintData : IComparable<ColorStintData>
    {
        // Lowest percent of battery for this stint
        public int Percent;
        // Color for icon in this stint
        public Color Color;
        public Color TextColor;

        public int CompareTo(ColorStintData other)
        {
            if (Percent == other.Percent)
                return 0;
            if (Percent > other.Percent)
                return -1;
            return 1;
        }

        public override string ToString()
        {
            return $"{Percent}% | {Color.ToString()}";
        }
    }
}