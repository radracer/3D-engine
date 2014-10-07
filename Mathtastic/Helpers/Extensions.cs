using System;

namespace Mathtastic.Helpers
{
    public static class Extensions
    {
        public static double ToRadians(this double val)
        {
            return (Math.PI/180)*val;
        }
    }
}
