﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {


	public void MyStartHost(){
		Debug.Log (Time.timeSinceLevelLoad + " Starting Host.");
		StartHost ();	
	}

	public override void OnStartHost(){
		Debug.Log (Time.timeSinceLevelLoad + " Host started.");
	}

	public override void OnStartClient (NetworkClient myClient){
		Debug.Log (Time.timeSinceLevelLoad + " client start requiested.");
		InvokeRepeating ("PrintDots", 0, 1f);
	}

	public override void OnClientConnect(NetworkConnection conn){
		Debug.Log (Time.timeSinceLevelLoad + " client connected to IP:" + conn.address);
		CancelInvoke ();
	}

	void PrintDots(){
		Debug.Log (".");
	}
}