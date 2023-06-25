using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{
    Transform controller;
    static public bool pickedUp = false;

    void Start()
    {

    }

    void Update()
    {
        float triggerLeft = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger);
        float triggerRight = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);

        if (OVRInput.GetUp(OVRInput.Button.One))
        {
            SceneManager.LoadScene(4);
        }

        if (pickedUp)
        {
            transform.position = controller.position;
            transform.rotation = controller.rotation;
        }

        if (OVRInput.Get(OVRInput.Button.Two))
        {
            if (pickedUp)
            {
                pickedUp = false;
                Destroy(gameObject.transform);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        pickedUp = true;
        controller =  .gameObject.transform;
    }
}
