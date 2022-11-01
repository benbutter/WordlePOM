using System;
using System.Collections.Generic;
using System.Text;

namespace WordlePOM
{
    public class InputElementXPathBuilder
    {
        public string GetXpathForInputItem(string itemName)
        {
            int div;
            int button;

            div = 1;

            button = GetButtonPositionOnTopLine(itemName);

            if (button == 0)
            {
                div = 2;
                button = GetButtonPositionOnMidLine(itemName);
            }

            if (button == 0)
            {
                div = 3;
                button = GetButtonPositionOnBottomLine(itemName);
            }

            return $"//*[@id=\"wordle-app-game\"]/div[2]/div[{div}]/button[{button}]";
        }

        private int GetButtonPositionOnTopLine(string itemName)
        {
            string[] topLineArray = new string[] { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P" };
            return Array.IndexOf(topLineArray, itemName) + 1;
        }

        private int GetButtonPositionOnMidLine(string itemName)
        {
            string[] midLineArray = new string[] { "A", "S", "D", "F", "G", "H", "J", "K", "L" };
            return Array.IndexOf(midLineArray, itemName) + 1;
        }

        private int GetButtonPositionOnBottomLine(string itemName)
        {
            string[] bottomLineArray = new string[] { "Enter", "Z", "X", "C", "V", "B", "N", "M", "Backspace" };
            return Array.IndexOf(bottomLineArray, itemName) + 1;
        }
    }
}
