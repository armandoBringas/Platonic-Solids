using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatonicSolids
{
    public static class Icosahedron
    {
        static readonly float _PHI = 1.618034f;

        public static int[] GetTriangles()
        {
            return new int[]
            {
                4,8,11, // Y PIVOT
                4,11,0,
                4,1,8,
                4,0,5,
                4,5,1,
                7,11,8, // B Pivot
                7,3,11,
                7,8,2,
                7,6,3,
                7,2,6,
                9,2,1, // D Pivot
                9,1,5,
                9,5,10,
                9,10,6,
                9,6,2,
                10,0,3, // E Pivot-semi
                10,3,6,
                10,5,0,
                8,1,2, // Backfill triangles
                11,3,0,
            };
        }

        public static Vector3[] GetVertices()
        {
            return new Vector3[]
            {
                new Vector3 (0, 1, -_PHI), // U 0
                new Vector3 (0, 1, _PHI), // V 1
                new Vector3 (0, -1, _PHI), // W 2
                new Vector3 (0, -1, -_PHI), // X 3
                new Vector3 (1, _PHI, 0), // Y 4
                new Vector3 (-1, _PHI, 0), // Z 5
                new Vector3 (-1, -_PHI, 0), // A 6
                new Vector3 (1, -_PHI, 0), // B 7
                new Vector3 (_PHI, 0, 1), // C 8
                new Vector3 (-_PHI, 0, 1), // D 9
                new Vector3 (-_PHI, 0, -1), // E 10
                new Vector3 (_PHI, 0, -1), // F 11
            };
        }
    }

}

