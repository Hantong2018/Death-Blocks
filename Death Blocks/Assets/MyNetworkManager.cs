using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {
    private NetworkManager networkManager;




	// Use this for initialization
    public void MyStartHost () {
        Debug.Log("Starting host at" + Time.timeSinceLevelLoad);
        StartHost() ;
    }
	
	// Update is called once per frame
	public override void OnStartHost () {
        Debug.Log("Host started at " + Time.timeSinceLevelLoad);
	}

    public override void OnStartClient(NetworkClient myClient) {
        Debug.Log(Time.timeSinceLevelLoad + " Client start requested.");
        InvokeRepeating("PrintDots", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client is connect to IP: " + conn.address);
        CancelInvoke ();
    }

    void PrintDots ()
    {
        Debug.Log(".");
    }
}
