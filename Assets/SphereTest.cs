using UnityEngine;
using System.Collections;

public class SphereTest : MonoBehaviour, IGvrGazeResponder {

	// Use this for initialization
	void Start () {
		SetGazedAt(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetGazedAt(bool gazedAt) {
		GetComponent<Renderer>().material.color = gazedAt ? Color.yellow : Color.green;
	}

	#region IGvrGazeResponder implementation

	/// Called when the user is looking on a GameObject with this script,
	/// as long as it is set to an appropriate layer (see GvrGaze).
	public void OnGazeEnter() {
		SetGazedAt (true);
	}

	/// Called when the user stops looking on the GameObject, after OnGazeEnter
	/// was already called.
	public void OnGazeExit() {
		SetGazedAt (false);
	}

	/// Called when the viewer's trigger is used, between OnGazeEnter and OnGazeExit.
	public void OnGazeTrigger() {
		
	}

	#endregion
}
