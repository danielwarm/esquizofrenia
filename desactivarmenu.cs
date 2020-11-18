using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactivarmenu : MonoBehaviour
{


    public GameObject menu;
    public GameObject menub;
    public GameObject holdera;
    public GameObject holderb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            menu.SetActive(false);
            menub.SetActive(false);
            holderb.SetActive(false);
            holdera.SetActive(true);
        }
    }
}
