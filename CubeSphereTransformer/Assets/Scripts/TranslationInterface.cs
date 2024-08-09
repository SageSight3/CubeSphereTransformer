using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TranslationInterface : MonoBehaviour //interface between the translation/rotation inputs and graph manager
{
    private Vector3 translationValues;
    private Vector3 rotationValues;

    public UnityEvent<Vector3> OnTranslationChanged;
    public UnityEvent<Vector3> OnRotationChanged;

    //takes an update value from an input and invokes their respective translation and rotation functions
    private bool SetComponent(ref Vector3 target, string component, string value, UnityEvent<Vector3> anEvent)
    {
        if (!float.TryParse(value, out float result)) //make sure value is valid
        {
            return false;
        }

        switch (component)
        {
            case "x":
                target.x = result;
                break;
            case "y":
                target.y = result;
                break;
            case "z":
                target.z = result;
                break;
            default:
                throw new System.Exception($"invalid component in SetComponent: {component}");
        }

        anEvent.Invoke(target); //runs RotateNodes() and TranslateNodes() when an event triggers
        return true;
    }

    public void SetXTranslation(string aValue)
    {
        SetComponent(ref translationValues, "x", aValue, OnTranslationChanged);
    }

    public void SetYTranslation(string aValue)
    {
        SetComponent(ref translationValues, "y", aValue, OnTranslationChanged);
    }

    public void SetZTranslation(string aValue)
    {
        SetComponent(ref translationValues, "z", aValue, OnTranslationChanged);
    }

    public void SetXRotation(string aValue)
    {
        SetComponent(ref rotationValues, "x", aValue, OnRotationChanged);
    }

    public void SetYRotation(string aValue)
    {
        SetComponent(ref rotationValues, "y", aValue, OnRotationChanged);
    }

    public void SetZRotation(string aValue)
    {
        SetComponent(ref rotationValues, "z", aValue, OnRotationChanged);
    }
}
