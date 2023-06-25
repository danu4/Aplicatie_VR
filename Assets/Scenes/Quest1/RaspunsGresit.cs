using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaspunsGresit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

        var cubeRenderer = gameObject.GetComponent<Renderer>();

        Color customColor = new Color(1.0f, 0.0f, 0.0f, 1.0f);

        cubeRenderer.material.SetColor("_Color", customColor);
    }

}
