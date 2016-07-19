using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LikeText : MonoBehaviour {

	private ArrayList likes = new ArrayList();
	private TextMesh textObject;

	private Text textField;

	// Use this for initialization
	void Start () {
		addLikes ("one.com");
		displayLikeText ();
	}
	
	// Update is called once per frame
	void Update () {
		addLikes ("two.com");
	}

	void displayLikeText() {
		textObject = GameObject.Find("LikeText").GetComponent<TextMesh>();

		string text = "";
		foreach(string item in likes )
		{
			text = text + "\n" + item;
		}
		textObject.text = text;
		Debug.Log ("Text is " + textObject.text);
	}

	void addLikes(string domain) {
		likes.Add (domain);
	}

	void clearLikes() {
		likes.Clear ();
	}
}
