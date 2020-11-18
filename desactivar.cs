using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactivar : MonoBehaviour
{

    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(desactive());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator desactive()
    {
       yield return new WaitForSeconds(2);

        canvas.SetActive(false);


    }
}
