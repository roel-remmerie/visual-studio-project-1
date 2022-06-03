using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.BoardGame.Core.Entities
{
    public class Player
    {
        Random random = new Random();
        public int horizontalValue;
        public int verticalValue;
        public int HorizontalValue
        {
            get { return horizontalValue; }
            set { horizontalValue = value; }
        }
        public int VerticalValue
        {
            get { return verticalValue; }
            set { verticalValue = value; }
        }

        public Player()
        {
            horizontalValue = random.Next(0,19);
            verticalValue = random.Next(0,19);
        }
        public int SetHorizontal()
        {
            return horizontalValue * 30;
        }
        public int SetVertical()
        {
            return verticalValue * 30;
        }
        public int Move(bool horizontal, bool toOrigin)
        {
            if (horizontal == true)
            {
                if (toOrigin == true)
                {
                    if (horizontalValue > 0)
                    {
                        HorizontalValue -= 1;
                    }
                }
                else
                {
                    if (horizontalValue < 19)
                    {
                        HorizontalValue += 1;
                    }
                }
                return horizontalValue * 30;
            }
            else
            {
                if (toOrigin == true)
                {
                    VerticalValue -= 1;
                }
                else
                {
                    VerticalValue += 1;
                }
                return verticalValue * 30;
            }
        }
    }
}
