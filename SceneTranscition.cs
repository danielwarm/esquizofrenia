using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTranscition : MonoBehaviour
{
    public GameObject nextCam;
    public GameObject CurrentCam;
    public Animator transitionAnimPanel;
    public float time;
    bool start = true;


    void Start()
    {
        start = true;
        CurrentCam.SetActive(true);
        nextCam.SetActive(false);
        StartCoroutine(FinishCut());
        
    }

    IEnumerator FinishCut()
    {
        start = false;
        if(start == false)
        {
           yield return new WaitForSeconds(time); 
           transitionAnimPanel.SetTrigger("End");
        }
        transitionAnimPanel.SetTrigger("Idle");
        CurrentCam.SetActive(false);
        nextCam.SetActive(true);
        
        
    }

}
