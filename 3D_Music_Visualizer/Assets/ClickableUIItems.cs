using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* Makes Button GameObjects clickable in VR by checking if GameObject has "Button" script. 
 * Checks every child of the UI.
*/

public class ClickableUIItems : MonoBehaviour {

	Transform uielement;

	// Use this for initialization
	void Start () {
		uielement = this.gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		Component[] buttons = uielement.gameObject.GetComponentsInChildren (typeof(Button), false);

		for (int i = 0; i < buttons.Length; i++) {
			if (buttons[i].gameObject.GetComponent<BoxCollider> () == null) {  //To check if already has BoxCollider
				MakeClickable (buttons[i].gameObject);
			}
		}
	}

	bool IsButton(GameObject o) {
		if (o.GetComponent<Button>() != null) {
			return true;
		} else {
			return false;
		}
	}

	void MakeClickable(GameObject o) {
		if (IsButton (o)) {
			o.AddComponent<BoxCollider> ();
			o.AddComponent<VRUIItem> ();
		}

	}


}
