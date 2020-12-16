using UnityEngine;
using System.Collections;
//this script is only added to the camera, that is waiting for a target
public class LookAtTarget : MonoBehaviour {

	static public GameObject target; // the target that the camera should look at

	void Start () {
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("LookAtTarget target not specified. Defaulting to parent GameObject");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (target)
			transform.LookAt(target.transform);
        if (Input.GetAxis("Mouse ScrollWheel") != 0f)
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView-(Input.GetAxis("Mouse ScrollWheel")*10), target.transform.localScale.x, 1000);
	}
}
