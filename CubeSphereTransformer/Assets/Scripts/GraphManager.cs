using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphManager : MonoBehaviour //manages all graph nodes, attached to graph container
{
    public enum NodeShape
    {
        Cube,
        Sphere
    }

    [SerializeField] private NodeShape[] shapeIndex;
    [SerializeField] private GameObject[] prefabIndex;

    private readonly Dictionary<NodeShape, GameObject> shapes = new Dictionary<NodeShape, GameObject>();
    [SerializeField] private List<GraphNode> nodes = new List<GraphNode>();
    private GraphContainer container;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < shapeIndex.Length; i++)
        {
            shapes.Add(shapeIndex[i], prefabIndex[i]); //links shapes to graph container, creates key value pair 
        }

        container = gameObject.GetComponent<GraphContainer>(); //fetches the instance of GraphContainer
    }

    public void CreateNode(NodeShape shape) //spawns a new node at a random position
    {
        if (!shapes.TryGetValue(shape, out GameObject prefab)) //validate shape prefab
        {
            Debug.LogError($"invalid shape received for CreateNode(): {shape}");
            return;
        }

        GameObject newNodeObject = Instantiate(prefab, transform); //set parent of node to graph container

        //make sure node prefab has a graph node component attached to it
        if (!newNodeObject.TryGetComponent(out GraphNode newNode)) 
        {
            Debug.LogError($"provided prefab has no GraphNode component: {newNodeObject.name}");
            return;
        }

        RandomizeNodePosition(newNode);
        nodes.Add(newNode);
    }

    private void RandomizeNodePosition(GraphNode aNode) //moves a created node to a random position in the graph
    {
        aNode.transform.position = container.GetRandomPosition();

        //sets newly spawned nodes rotation to 0 in case the graph container's rotation has already been changed
        aNode.transform.rotation = Quaternion.identity;
    }


    /*
     * since input transformations are intended to be applied to all nodes in the graph, instead of applying the them to the
     * nodes themselves, they will be applied to the whole graph container, relativity woot woot
    */

    public void TranslateNodes(Vector3 translationVector) 
    {
        transform.position = translationVector;
    }

    public void RotateNodes(Vector3 rotationAngles)
    {
        //takes rotation input values, converts them to radians, and applies them to the graph container's transform
        transform.rotation = Quaternion.Euler(rotationAngles * Mathf.Rad2Deg);
    }

    public void ClearGraph()
    {
        foreach(GraphNode node in nodes)
        {
            DestroyNode(node);
        }
        nodes.Clear();
    }

    private void DestroyNode(GraphNode node)
    {
        Destroy(node.gameObject);
    }
}
