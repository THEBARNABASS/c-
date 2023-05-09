using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conversor.classe
{
    public static class Dollar
    {
        public static float m { get; set; }
        public static float ct { get; set; }
        public static float rpd(float r, float ct)
        {
           return m = r/ct;
        }
        public static float dpr(float d, float ct)
        {
            return m = d * ct;
        }
    }
}