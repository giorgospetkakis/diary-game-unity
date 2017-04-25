using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCue : MonoBehaviour {

	ArrayList history;
	Queue<string> cuedText;
	Text t;
	int linesOnCurrent = 0;
	// Use this for initialization
	void Awake () {
		cuedText = FileReader.getScript();
		history = new ArrayList();
		t = GetComponent<Text>();
	}

	public string showNextLine() {
		string line = "";
		if(cuedText.Count > 0) {
			if(linesOnCurrent > 5) {
				clearPanel();
			}
			line = cuedText.Peek();
			cuedText.Dequeue();
			t.text = t.text + line;
			linesOnCurrent++;
		}
		return line;
	}

	public void clearPanel() {
		history.Add(new string (t.text.ToCharArray()));
		t.text = "";
		linesOnCurrent = 0;
	}
}
