using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlatonicSolids;

public class MeshGeometry : MonoBehaviour
{
    private enum PlatonicSolidSelection
    {
        Tetrahedron,
        Cube,
        Octahedron,
        // Dodecahedron /*TODO*/
        Icosahedron,
    }

    [SerializeField]
    PlatonicSolidSelection platonicSolid;

    protected MeshFilter MeshFilter;
    protected Mesh Mesh;


#pragma warning disable IDE0051 // Remove unused private members
    // Start is called before the first frame update
    void Start()
    {
        Mesh = new Mesh
        {
            name = "GeneratedMesh",
            vertices = GenerateVertices(),
            triangles = GenerateTriangles()
        };

        Vector2[] uvs = new Vector2[Mesh.vertices.Length];

        for (int i = 0; i < uvs.Length; i++)
        {
            uvs[i] = new Vector2(Mesh.vertices[i].x, Mesh.vertices[i].z); ;
        }
        Mesh.uv = uvs;

        Mesh.RecalculateNormals();
        Mesh.RecalculateBounds();

        MeshFilter = gameObject.AddComponent<MeshFilter>();
        MeshFilter.mesh = Mesh;
    }

    private int[] GenerateTriangles()
    {
        return platonicSolid switch
        {
            PlatonicSolidSelection.Tetrahedron => Tetrahedron.GetTriangles(),
            PlatonicSolidSelection.Cube => Cube.GetTriangles(),
            PlatonicSolidSelection.Octahedron => Octahedron.GetTriangles(),
            PlatonicSolidSelection.Icosahedron => Icosahedron.GetTriangles(),
            _ => null,
        };
    }

    private Vector3[] GenerateVertices()
    {
        return platonicSolid switch
        {
            PlatonicSolidSelection.Tetrahedron => Tetrahedron.GetVertices(),
            PlatonicSolidSelection.Cube => Cube.GetVertices(),
            PlatonicSolidSelection.Octahedron => Octahedron.GetVertices(),
            PlatonicSolidSelection.Icosahedron => Icosahedron.GetVertices(),
            _ => null,
        };
    }

    // http://www.sacred-geometry.es/?q=en/content/phi-sacred-solids
}


