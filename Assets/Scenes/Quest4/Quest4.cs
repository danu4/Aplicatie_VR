using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Quest4 : MonoBehaviour
{
    private TouchScreenKeyboard overlayKeyboard;
    public static string inputText = "";
    public TMP_InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        overlayKeyboard = TouchScreenKeyboard.Open("");
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.One))
        {
            SceneManager.LoadScene(5);
        }

        if (OVRInput.Get(OVRInput.Button.Two))
        {
            SceneManager.LoadScene(4);
        }

        if (overlayKeyboard.text != null)
        {
            inputField.text = overlayKeyboard.text;
        }
        
    }
}
