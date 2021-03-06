﻿using System;

namespace WindowMake.Entity
{
    public partial class slopeInfo
    {
        public string BM { get; set; }
        public string Name { get; set; }
        public Nullable<float> Height { get; set; }
        public Nullable<float> Inclination { get; set; }
        public string Stake { get; set; }
        public string PointX { get; set; }
        public string PointY { get; set; }
        public Nullable<short> Direction { get; set; }
        public string MapID { get; set; }
        public string Mesg { get; set; }
    }
}