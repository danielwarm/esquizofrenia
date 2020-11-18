using UnityEngine;
using System.Collections;

public class Interactor : MonoBehaviour {

    public float interactRange;

    private InteractiveObject interactiveObject;
    private IniciarCinematica iniciarCinematica;
    private Camera cam;
    private RaycastHit hit;
    private ReticleController reticleController;
    

	void Start () {
        cam = Camera.main;
        reticleController = GameObject.FindObjectOfType<ReticleController>();
	}
	
	void Update () {
        Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, interactRange);
        if (hit.transform) {
            interactiveObject = hit.transform.GetComponent<InteractiveObject>();
            iniciarCinematica = hit.transform.GetComponent<IniciarCinematica>();
        } else {
            interactiveObject = null;
            
        }

        reticleController.ShowIcon(interactiveObject);

        if (Input.GetKeyDown(KeyCode.E)) {
            if (interactiveObject) {
                interactiveObject.PerformAction();
            }
            if (iniciarCinematica) {
                iniciarCinematica.PerformAction();
            }
        }
    }
}
