using UnityEngine;
using System.Collections;
using System.IO; //System.IO.FileInfo, System.IO.StreamReader, System.IO.StreamWriter
using System; //Exception
using System.Text; //Encoding
using Ovr;

public class TextureScale  {

	public static string configTextureScale = "ConfigTextureScale.txt";

	public static void InitTextureScale(){
		String url;
		if (Application.platform == RuntimePlatform.OSXEditor ||
		    Application.platform == RuntimePlatform.WindowsEditor){
			url = Application.dataPath + "/data/" + configTextureScale;
		}else if (Application.platform == RuntimePlatform.OSXPlayer){
			url = Application.dataPath + "/../../data/" + configTextureScale;
		}else if (Application.platform == RuntimePlatform.WindowsPlayer){
			url = Application.dataPath + "/../data/" + configTextureScale;
		}else{
			url = "";
		}

		FileInfo fi = new FileInfo(url);
		try {
			using (TextReader reader = new StreamReader(fi.FullName, Encoding.UTF8))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					string[] data = line.Split(',');
					Debug.Log (data[0] + " " + data[1]);
					switch(data[0]) {
					case "nativeTextureScale":
						OVRManager.instance.nativeTextureScale = float.Parse(data[1]);
						break;
					case "virtualTextureScale":
						OVRManager.instance.virtualTextureScale = float.Parse(data[1]);
						break;
					}
				}
			}
		} catch(Exception e) {
			//Debug.Log (e.StackTrace);
		}
	}
}
