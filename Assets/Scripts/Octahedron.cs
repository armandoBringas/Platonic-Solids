using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatonicSolids
{
    public static class Octahedron
    {
        public static int[] GetTriangles()
        {
            return new int[]
            {
                0,5,3,
                0,3,2,
                0,2,4,
                0,4,5,
                1,3,5,
                1,2,3,
                1,4,2,
                1,5,4,
            };
        }

        public static Vector3[] GetVertices()
        {
            return new Vector3[]
            {
                new Vector3 (0, 2, 0), //G 0
                new Vector3 (0, -2, 0), //H 1
                new Vector3 (2, 0, 0), //I 2
                new Vector3 (0, 0, 2), //J 3
                new Vector3 (0, 0, -2), //K 4
                new Vector3 (-2, 0, 0), //L 5
            };
        }
    }

}

