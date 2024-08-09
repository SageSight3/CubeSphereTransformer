using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphContainer : MonoBehaviour
{
    [SerializeField] private Vector3 dimensions;
    [SerializeField] private Transform graphOrigin;

    public Vector3 GetRandomPosition()
    {
        return new Vector3(
            Random.value * dimensions.x,
            Random.value * dimensions.y,
            Random.value * dimensions.z
        ) + graphOrigin.position - dimensions/2;
    }

    private void OnDrawGizmos() //debug
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(graphOrigin.position, dimensions);
    }
} 
