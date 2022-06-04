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
        public string positionId;
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
        public string PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }

        public Player()
        {
            HorizontalValue = random.Next(0,19);
            VerticalValue = random.Next(0,19);
            PositionId = $"{horizontalValue}-{verticalValue}";
        }
        public int SetHorizontal()
        {
            return horizontalValue;
        }
        public int SetVertical()
        {
            return verticalValue;
        }
        public string SetPosition()
        {
            PositionId = $"{horizontalValue}-{verticalValue}";
            return positionId;
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
                return horizontalValue;
            }
            else
            {
                if (toOrigin == true)
                {
                    if (verticalValue > 0)
                    {
                        VerticalValue -= 1;
                    }
                }
                else
                {
                    if (verticalValue < 19)
                    {
                        VerticalValue += 1;
                    }
                }
                return verticalValue;
            }
        }
    }
}
