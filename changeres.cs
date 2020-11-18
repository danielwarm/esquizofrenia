using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeres : MonoBehaviour
{
    public AudioSource audio;
    public Button button;
    public int wide;
    public int lenght;
   
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        audio.Play();
        Screen.SetResolution(wide, lenght,true);
    }
}
