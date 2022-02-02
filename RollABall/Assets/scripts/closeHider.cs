using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeHider : MonoBehaviour
{
    GameObject closeBtn;
    // Start is called before the first frame update
    void Start()
    {
        closeBtn = GameObject.Find("closeButton");
        closeBtn.SetActive(false);
    }

}
