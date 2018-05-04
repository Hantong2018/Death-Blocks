using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour 
{
	public Color[] colors = new Color[4];

	void Start()
	{
		colors[0] = Color.blue;
		colors[1] = Color.red;
		colors[2] = Color.magenta;
		colors[3] = Color.white;
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
			gameObject.GetComponent<Renderer> ().material.color = Color.blue;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			gameObject.GetComponent<Renderer> ().material.color = Color.red;
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;
		}else if (Input.GetKeyDown (KeyCode.Alpha4)) {
			gameObject.GetComponent<Renderer> ().material.color = Color.white;
		}
			




	}

}
