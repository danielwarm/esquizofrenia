using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarCinematica : MonoBehaviour
{
    public GameObject CurrentCam;
     
    public GameObject nextCam;

    public Animator transitionAnimPanel;

    public float timeTransition;

    public float timeCorte;

    [SerializeField]
    private bool iniciar = false, noIniciar = false;

    
    public string myMessage;

    private TextAnimator textAnimator;

    [SerializeField]
    private AudioSource aSource;

    void Start() {
        textAnimator = FindObjectOfType<TextAnimator>();
        aSource = GetComponent<AudioSource>();
    }

    IEnumerator StartCinematic()
    {      
        yield return new WaitForSeconds(timeCorte);     
        yield return new WaitForSeconds(timeTransition);           
    }

    public void PerformAction() {
        if (!noIniciar) {
            if (aSource) 
            {
                aSource.Play();
            }

            if (Input.GetKeyDown(KeyCode.E)) {
                if (iniciar) 
                {
                    
                    CurrentCam.SetActive(true);
                    nextCam.SetActive(false);
                    StartCoroutine(FinishCut());
                    
                } 
                else 
                {
                    textAnimator.Show(myMessage);
                    transitionAnimPanel.SetTrigger("End");
                }
                

            }
        }
        else 
        {
            textAnimator.Show(myMessage);
            
        }
    }

    IEnumerator FinishCut()
    {   
        yield return new WaitForSeconds(timeTransition);
        transitionAnimPanel.SetTrigger("End");
        transitionAnimPanel.SetTrigger("Idle");
        yield return new WaitForSeconds(timeCorte);
        CurrentCam.SetActive(false);
        nextCam.SetActive(true);
        
        
    }
}
