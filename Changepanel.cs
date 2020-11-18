using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Changepanel : MonoBehaviour
{

   public GameObject panel;
    public GameObject panela;
    public Button button;
    public AudioSource audio;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        audio.Play();
        panel.SetActive(true);
        panela.SetActive(false);
    }
}
