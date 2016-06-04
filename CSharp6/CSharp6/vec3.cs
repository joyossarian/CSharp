using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class vec3
    {
        public vec3() { }

        public vec3(float e0, float e1, float e2) {
            e[0] = e0;
            e[1] = e1;
            e[2] = e2;
        }

        float x() { return e[0]; }
        float y() { return e[1]; }
        float z() { return e[2]; }
        float r() { return e[0]; }
        float g() { return e[1]; }
        float b() { return e[2]; }


        float[] e = new float[3];
    }
}
