using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class offMapReset : MonoBehaviour
{
    public float threshold = -10f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < threshold){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
