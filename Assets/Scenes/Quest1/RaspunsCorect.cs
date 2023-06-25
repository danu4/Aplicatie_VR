using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaspunsCorect : MonoBehaviour
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

        Color customColor = new Color(0.4f, 0.9f, 0.7f, 1.0f);

        cubeRenderer.material.SetColor("_Color", customColor);
    }

}
