using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    class Powerups
    {


        public int size, x, y;
        public string type;
        public SolidBrush powerupBrush;
        public Powerups(int _x, int _y, int _size, string _type, SolidBrush _powerBrush)
        {
            x = _x;
            y = _y;
            size = _size;
            type = _type;
            powerupBrush = _powerBrush;
        }

        public void Move(int speed)
        {
            y += speed;
        }

        
      
    }
}
