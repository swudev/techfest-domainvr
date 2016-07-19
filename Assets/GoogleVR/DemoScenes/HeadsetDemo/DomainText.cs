using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class DomainText : MonoBehaviour, IGvrGazeResponder {
	TextMesh domainText;
	// Use this for initialization
	void Start () {
		domainText = GameObject.Find("DomainText").GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	protected void UpdateDomainName(string domain) {
		domainText.text = domain;
	}

	/// Called when the user is looking on a GameObject with this script,
	/// as long as it is set to an appropriate layer (see GvrGaze).
	public void OnGazeEnter() {
		UpdateDomainName ("enter.com");
	}

	/// Called when the user stops looking on the GameObject, after OnGazeEnter
	/// was already called.
	public void OnGazeExit() {
		UpdateDomainName ("exit.com");
	}

	/// Called when the viewer's trigger is used, between OnGazeEnter and OnGazeExit.
	public void OnGazeTrigger() {
		UpdateDomainName ("click.com");
	}
}
