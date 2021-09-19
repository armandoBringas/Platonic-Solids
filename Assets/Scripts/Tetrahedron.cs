using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatonicSolids
{
    public static class Tetrahedron
    {
        public static int[] GetTriangles()
        {
            return new int[]
            {
                0,1,2,
                0,3,1,
                0,2,3,
                1,3,2,
            };
        }

        public static Vector3[] GetVertices()
        {
            return new Vector3[]
            {
                new Vector3 (1, 1, -1),
                new Vector3(-1, 1, 1),
                new Vector3(1, -1, 1),
                new Vector3(-1, -1, -1),
            };
        }
    }
}

