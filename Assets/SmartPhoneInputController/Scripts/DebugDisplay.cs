using UnityEngine;
using System.Collections;

public class DebugDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		string msg = "";
		if (SmartPhoneInput.IsConnected()) {
			msg += "Connected, ";
			msg += "(" + SmartPhoneInput.PadX + "," + SmartPhoneInput.PadY + ")";
			msg += "(" + SmartPhoneInput.PadGradX + "," + SmartPhoneInput.PadGradY + "," + SmartPhoneInput.PadGradZ + ")";
		} else {
			msg += "Disconnected: Please Access " + SmartPhoneController.WebUrl;
		}
		guiText.text = msg;
	}
}
