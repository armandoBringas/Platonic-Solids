using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatonicSolids
{
    public static class Cube
    {
        public static int[] GetTriangles()
        {
            return new int[]
            {
                0,1,2, //+XZ
                0,2,3,
                4,7,6, //-XZ
                6,5,4,
                0,5,6, //+ZY 
                0,6,1,
                3,2,4, //-ZY
                2,7,4,
                0,3,4, //+XY
                0,4,5,
                1,6,2, //-XY
                2,6,7,
            };
        }

        public static Vector3[] GetVertices()
        {
            return new Vector3[]
            {
                new Vector3 (1, 1, 1),
                new Vector3 (1, 1, -1),
                new Vector3 (-1, 1, -1),
                new Vector3 (-1, 1, 1),
                new Vector3 (-1, -1, 1),
                new Vector3 (1, -1, 1),
                new Vector3 (1, -1, -1),
                new Vector3 (-1, -1, -1),
            };
        }
    }
}
