using UnityEngine;
using System.Collections;

public class ReticleController : MonoBehaviour {

    [SerializeField]
    private GameObject defaultIcon, interactIcon;

	void Start () {
        defaultIcon = GameObject.Find("DefaultIcon");
        interactIcon = GameObject.Find("InteractIcon");
        interactIcon.SetActive(true);
	}

    public void ShowIcon(bool isInteractIcon) {
        defaultIcon.SetActive(!isInteractIcon);
        interactIcon.SetActive(isInteractIcon);
    }

}
