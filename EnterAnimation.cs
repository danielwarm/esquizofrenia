using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterAnimation : MonoBehaviour
{
    public GameObject CurrentCam; 
    public GameObject nextCam;
    public Animator transitionAnimPanel;
    public float timeCam;
    public float timeTransition;
    bool start = true;

    void Start()
    {
        transitionAnimPanel.SetTrigger("Idle");
        start = true;
        CurrentCam.SetActive(true);
        nextCam.SetActive(false);
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {   
        transitionAnimPanel.SetTrigger("Idle");
        start = false;
        if(start == false)
        {
           yield return new WaitForSeconds(timeTransition);  
           transitionAnimPanel.SetTrigger("End");
        }
        transitionAnimPanel.SetTrigger("Idle");
        yield return new WaitForSeconds(timeCam);
        CurrentCam.SetActive(false);
        nextCam.SetActive(true);
    }
    
}
