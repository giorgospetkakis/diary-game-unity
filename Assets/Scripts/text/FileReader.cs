using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileReader {
	static string filename = "script.txt";
	static Queue<string> scriptSequence = new Queue<string>();
	public static Queue<string> getScript(){
		StreamReader sr = new StreamReader(Application.dataPath + "/" + filename);
		string contents = sr.ReadToEnd();
		sr.Close();

		string[] split = contents.Split('_');
		for(int i = 0; i < split.Length; i++){
			Debug.Log(split[i]);
			scriptSequence.Enqueue(split[i]);
		}

		return scriptSequence;
	}
}
