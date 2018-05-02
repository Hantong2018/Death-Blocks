using UnityEngine;
using System.Collections;

public class changecolor : MonoBehaviour 
{
	public Color[] colors = new Color[4];

	void Start()
	{
		colors[0] = Color.cyan;
		colors[1] = Color.red;
		colors[2] = Color.green;
		colors[3] = new Color(255, 165, 0);
		gameObject.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
	}
	void OnTriggerEnter(Collider other)
	{
		
		if (other.gameObject.tag == "block") {
			Debug.Log ("hello");

		}
		
	}
	void Update()
	{

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			gameObject.GetComponent<Renderer> ().material.color = Color.cyan;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			gameObject.GetComponent<Renderer> ().material.color = Color.red;
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			gameObject.GetComponent<Renderer> ().material.color = Color.green;
		}else if (Input.GetKeyDown (KeyCode.Alpha4)) {
			gameObject.GetComponent<Renderer> ().material.color = new Color(255, 165, 0);
		}
			




	}

}
