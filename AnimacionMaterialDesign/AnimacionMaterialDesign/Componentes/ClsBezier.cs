using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimacionMaterialDesign.Componentes
{
    class ClsBezier
    {
        // t -> Current Time.
        // b -> Start Value.
        // c -> Change in value.
        // d -> Duration.

        //cubic-bezier(0.0, 0.0, 0.2, 1);
        public static float easeInCubic (float t, float b, float c, float d)
        {
            t /= d;
            return c * t * t * t + b;
        }


        public static float easeInOutCubic(float t, float b, float c, float d)
        {
            t /= d / 2;
            if (t < 1) return c / 2 * t * t * t + b;
            t -= 2;
            return c / 2 * ( t * t * t + 2 ) + b;
        }

        public static float easeOutCubic(float t, float b, float c, float d)
        {
            t /= d;
            t--;
            return c * ( t * t * t + 1 ) + b;
        }

    }
}
