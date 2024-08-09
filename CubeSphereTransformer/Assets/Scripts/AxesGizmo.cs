using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//draws graph axes
public class AxesGizmo : MonoBehaviour
{
    [SerializeField] private Material mat;
    [SerializeField] private Color[] colors;
    [SerializeField] private Vector3[] axes;
    [SerializeField] private Transform origin;

    void OnDrawGizmos()
    {
        Draw();
    }

    void OnPostRender()
    {
        Draw();
    }

    void Draw()
    {
        // GL.PushMatrix();
        mat.SetPass(0);
        // GL.LoadIdentity();
        // GL.MultMatrix(transform.localToWorldMatrix);
        int limit = Mathf.Min(axes.Length, colors.Length);
        for (int i = 0; i < limit; i++)
        {
            GL.Begin(GL.LINES);
            GL.Color(colors[i]);
            GL.Vertex(origin.position);
            GL.Vertex(origin.position + axes[i]);
            GL.End();
        }
        // GL.PopMatrix();
    }
}
