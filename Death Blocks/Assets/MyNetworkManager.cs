using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : MonoBehaviour {
    private NetworkManager networkManager;




	// Use this for initialization
	void Start () {
        networkManager = GetComponent<NetworkManager>();
	}

    public void MyStartHost () {
        Debug.Log("Starting host at" + Time.timeSinceLevelLoad);
        networkManager.StartHost();
    }
	
	// Update is called once per frame
	override void Update () {
        Debug.Log("Host started at " + Time.timeSinceLevelLoad);
	}
}
