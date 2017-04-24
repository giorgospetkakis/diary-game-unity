using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCue : MonoBehaviour {

	ArrayList history;
	Queue<string> cuedText;
	Text t;
	// Use this for initialization
	void Awake () {
		cuedText = FileReader.getScript();
		history = new ArrayList();
		t = GetComponent<Text>();
	}

	void Start() {
		showNextLine();
		showNextLine();
	}

	public void showNextLine() {
		string line = cuedText.Peek();
		cuedText.Dequeue();
		t.text = t.text + line;
	}

	public void clearPanel() {
		history.Add(new string (t.text.ToCharArray()));
		t.text = "";
	}
}
