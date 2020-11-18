using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarmenu : MonoBehaviour
{



    public GameObject menu;
    public GameObject holdera;
    public GameObject holderb;
   
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            menu.SetActive(true);
            holderb.SetActive(true);
            holdera.SetActive(false);
        }
    }
}
