using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToolbarInterface : MonoBehaviour //interface between the toolbar and graph manager
{

    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private GraphManager graphManager;

    [SerializeField] private GraphManager.NodeShape[] nodeShapeIndex;

    //creates a new graph node when the Spawn Object button is pushed
    public void OnSpawnObjectButtonPressed()
    {
        GraphManager.NodeShape shape = nodeShapeIndex[dropdown.value];

        if (shape == GraphManager.NodeShape.Cube) //will only spawn one node if selected object type is cube
        {
            graphManager.CreateNode(shape);
        }
        else //spawn 10-20 nodes if the sselected object type is sphere
        {
            int numOfSpheres = Mathf.FloorToInt(Random.value * 11) + 10;
            for (int i = 0; i < numOfSpheres; i++)
            {
                graphManager.CreateNode(shape);
            }
        }
    }

    //clears the graph when the clear graph button is pushed
    public void OnClearGraphButtonPressed()
    {
        graphManager.ClearGraph();
    }

    public void Quit() //close application
    {
        Application.Quit();
    }
}
