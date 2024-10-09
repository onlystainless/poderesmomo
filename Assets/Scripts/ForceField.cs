using UnityEngine;

public class ForceField : MonoBehaviour
{
    public GameObject forceFieldObject;  // The visual object for the force field

    void Start()
    {
        // Ensure the force field starts inactive
        if (forceFieldObject != null)
        {
            forceFieldObject.SetActive(false);
        }
    }

    void Update()
    {
        // Check if 'E' key is held down
        if (Input.GetKey(KeyCode.E))
        {
            ActivateForceField();
        }
        else
        {
            DeactivateForceField();
        }
    }

    void ActivateForceField()
    {
        // Enable the force field visual if it's not already active
        if (forceFieldObject != null && !forceFieldObject.activeInHierarchy)
        {
            forceFieldObject.SetActive(true);
            Debug.Log("Force field activated!");
        }
    }

    void DeactivateForceField()
    {
        // Disable the force field visual if it's currently active
        if (forceFieldObject != null && forceFieldObject.activeInHierarchy)
        {
            forceFieldObject.SetActive(false);
            Debug.Log("Force field deactivated!");
        }
    }
}