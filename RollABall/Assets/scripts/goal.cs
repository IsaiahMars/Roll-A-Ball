using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other){
        playerController component = other.gameObject.GetComponent<playerController>();
        if(component != null){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
