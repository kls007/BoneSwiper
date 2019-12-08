using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public MeshFilter meshFilter;
    public MeshRenderer meshRenderer;

    public int circle_count;
    public float sideLength = 2;

    public Material mat;

    void Start()
    {
        DrawPolygon();
        //RectTransform
    }

    void DrawPolygon()
    {
        Mesh mesh = PrepareMesh();

        Vector3[] vertices = new Vector3[circle_count + 1];
        vertices[0] = Vector3.zero;
        float pre_rad = Mathf.Deg2Rad * 360 / circle_count;
        for (int i = 0; i < circle_count; i++)
        {
            float deg = -i * pre_rad;
            float x = Mathf.Cos(deg);
            float y = Mathf.Sin(deg);
            vertices[i + 1] = new Vector3(x, y, 0) * sideLength;
        }
        mesh.vertices = vertices;

        int[] triangles = new int[circle_count * 3];
        for (int i = 0; i < triangles.Length; i += 3)
        {
            int first = 0;
            int second = i / 3 + 1;
            int third = second + 1;
            if (third > circle_count)
            {
                third = 1;
            }
            triangles[i] = first;
            triangles[i + 1] = second;
            triangles[i + 2] = third;
        }
        mesh.triangles = triangles;
    }

    Mesh PrepareMesh()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();
        
        //meshRenderer.material = mat;
        Mesh mesh = meshFilter.mesh;
        mesh.Clear();

        return mesh;
    }
    
}
