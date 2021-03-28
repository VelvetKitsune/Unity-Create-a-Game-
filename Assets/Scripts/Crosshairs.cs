using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshairs : MonoBehaviour {
	
	public LayerMask targetMask;
	public SpriteRenderer dot;
	public Transform crosshairs2;
	public Transform crosshairs3;
	public Color dotHighlightColour;
	Color originalDotColour;
	
	void Start() {
		Cursor.visible = false;
		originalDotColour = dot.color;
	}
	
    void Update() {
        transform.Rotate (Vector3.forward * 45 * Time.deltaTime);
        crosshairs2.transform.Rotate (Vector3.forward * -90 * Time.deltaTime);
        crosshairs3.transform.Rotate (Vector3.forward * 45 * Time.deltaTime);
    }
	
	public void DetectTargets (Ray ray) {
		if (Physics.Raycast (ray, 100, targetMask)) {
			dot.color = dotHighlightColour;
		} else {
			dot.color = originalDotColour;
		}
	}
}
