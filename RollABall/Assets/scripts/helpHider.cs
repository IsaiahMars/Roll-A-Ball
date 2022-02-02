using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpHider : MonoBehaviour
{
    GameObject helpWindow;
    // Start is called before the first frame update
    void Start()
    {
        helpWindow = GameObject.Find("Image");
        helpWindow.SetActive(false);
    }

}
