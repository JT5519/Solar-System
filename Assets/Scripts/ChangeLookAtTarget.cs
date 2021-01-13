using UnityEngine;
using System.Collections;
//this script is added to each object that can be looked at by clicking on them
public class ChangeLookAtTarget : MonoBehaviour {

	public GameObject target; // the target that the camera should look at
	void Start() {
		if (target == null) 
		{
			target = this.gameObject;
		}
	}

	// Called when MouseDown on this gameObject
	void OnMouseDown () {
		// change the target of the LookAtTarget.cs script to be this gameobject.
		LookAtTarget.target = target;
		// change the field of view on the perspective camera based on the distance from center of world, clamp it to a reasonable field of view
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x,target.transform.localScale.x, 100);
	}
}
