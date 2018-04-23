using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class RaycastEvent : MonoBehaviour {
    Camera camera;

	// Use this for initialization
	void Start () {
        camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        Ray ray = camera.ScreenPointToRay(new Vector3(0.5f, 0.5f, 0f));

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            hit.transform.gameObject.GetComponent<MeshRenderer>().enabled = 
                !hit.transform.gameObject.GetComponent<MeshRenderer>().enabled;
        }
    }
}
