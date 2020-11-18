using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string ChargeLevel;

    void OnTriggerEnter (Collider other) {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(ChargeLevel);
        }
    }

}
