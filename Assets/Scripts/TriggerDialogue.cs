using UnityEngine;
using System.Collections;

public class TriggerDialogue : MonoBehaviour {

	private bool display;
	private GameObject speaker;
	private Transform speakerTransform;
	private Vector3 position;
	private Camera cam;

	void Start() {
		speaker = gameObject;
		speakerTransform = speaker.transform;
		print (speakerTransform.ToString());
	}

	void OnTriggerEnter2D(Collider2D other) {
		display = true;
		cam = Camera.current;
	}

	void OnTriggerStay2D(Collider2D other) {
		position = cam.WorldToScreenPoint(speakerTransform.position);
	}

	void OnTriggerExit2D(Collider2D other) {
		display = false;
	}

	/*IEnumerator ShowMessage (string message, float delay) {
		guiText.text = message;
		guiText.enabled = true;
		yield return new WaitForSeconds(delay);
		guiText.enabled = false;
	}*/
	
	void OnGUI() {
		if(display == true) {
			print (position.y.ToString());
			GUI.Label(new Rect (position.x, position.y, 100, 20), "Hello World");

		}
	}

}