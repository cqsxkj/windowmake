﻿using System;
using System.Drawing;

namespace WindowMake.Device
{
    public class PlldiObject : PLCEqu
    {
        public PlldiObject(Point p)
        {
            this.init(p);
        }

        public PlldiObject()
        {
            this.init(this.LocationInMap);
        }

        public void init(Point p)
        {
            this.LocationInMap = p;
            //this.end = new Point(p.X + 30, p.Y + 30);
            this.equtype = MyObject.ObjectType.P_LLDI;
            this.equ.EquID = (int)equtype + "0001";
            this.picName = "P_LLDI.png";
            this.equ.EquName = "液位检测仪";
            equTypeName = equ.EquName;
        }
    }
}
