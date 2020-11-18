using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutSceneEnter : MonoBehaviour
{
    #region Atributos
    public GameObject thePlayer;
    public GameObject CutSceneCam;
    public int time;
    public bool Avisador = false;


    public GameObject TriggerActual;
    public GameObject TriggerSiguiente;
    #endregion


    #region Metodos

    void Start()
    {
        TriggerSiguiente.SetActive(false); // Inicia el trigger que sigue desactivado
    }

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        CutSceneCam.SetActive(true);
        thePlayer.SetActive(false);
        Avisador = true;
        StartCoroutine(FinishCut());

    }

    
    IEnumerator FinishCut()
    {   
        yield return new WaitForSeconds(time);
        CutSceneCam.SetActive(false);
        thePlayer.SetActive(true);
        
    }

    private void Update() // El "Update" verifica todo el tiempo si el "avisador" del "CutSceneEnter" esta Activado 
    {
        if(Avisador == true)
        {
            TriggerSiguiente.SetActive(true);
        }
        else
        {
            TriggerActual.SetActive(true);
            TriggerSiguiente.SetActive(false);
        }
    }


    #endregion


}
