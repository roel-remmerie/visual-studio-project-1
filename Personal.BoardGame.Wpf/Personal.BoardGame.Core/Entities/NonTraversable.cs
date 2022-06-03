using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.BoardGame.Core.Entities
{
    public class NonTraversable
    {
        public int HorizontalPos
        {
            get { return HorizontalPos; }
            set { HorizontalPos = value; }
        }
        public int VerticalPos
        {
            get { return VerticalPos; }
            set { VerticalPos = value; }
        }
        public string PositionId
        {
            get { return PositionId; }
            set { PositionId = value; }
        }

        public NonTraversable(int horizontalPos, int verticalPos)
        {
            HorizontalPos = horizontalPos;
            VerticalPos = verticalPos;
        }

        public override string ToString()
        {
            return $"{HorizontalPos} - {VerticalPos}";
        }
    }
}
