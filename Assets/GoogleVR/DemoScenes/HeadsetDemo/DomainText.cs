using UnityEngine;
using System.Collections;

public class DomainText : MonoBehaviour, IGvrGazeResponder {
	TextMesh textObject;
	// Use this for initialization
	void Start () {
		textObject = GameObject.Find("DomainText").GetComponent<TextMesh>();
		textObject.text = "test.com";
		Debug.Log ("Text is " + textObject.text);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateDomainName(string domain) {
		textObject.text = domain;
		Debug.Log ("Text is " + textObject.text);
	}

	#region IGvrGazeResponder implementation

	/// Called when the user is looking on a GameObject with this script,
	/// as long as it is set to an appropriate layer (see GvrGaze).
	public void OnGazeEnter() {
		Debug.Log ("Gaze Enter");
		UpdateDomainName("enter.com");
	}

	/// Called when the user stops looking on the GameObject, after OnGazeEnter
	/// was already called.
	public void OnGazeExit() {
		Debug.Log ("Gaze Exit");
		UpdateDomainName("exit.com");
	}

	/// Called when the viewer's trigger is used, between OnGazeEnter and OnGazeExit.
	public void OnGazeTrigger() {
		Debug.Log ("Gaze Trigger");
		UpdateDomainName("trigger.com");
	}

	#endregion
}
