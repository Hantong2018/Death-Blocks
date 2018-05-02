using UnityEngine;
using System.Collections;

public class colorchangeBlocks : MonoBehaviour 
{
	Color[] colors = new Color[4];
	public Score refScript;
	void Start()
	{
		colors[0] = Color.cyan;
		colors[1] = Color.red;
		colors[2] = Color.green;
		colors[3] = new Color(255, 165, 0);
		gameObject.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
		refScript = GameObject.FindGameObjectWithTag ("Player").GetComponent<Score>();

	}

	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player") {
			Debug.Log ("hit player");
			if (gameObject.GetComponent<Renderer> ().material.color == other.gameObject.GetComponent<Renderer> ().material.color) {
				Debug.Log ("colors match");
				Physics.IgnoreCollision (gameObject.GetComponent<Collider> (), other.gameObject.GetComponent<Collider> ());
			} else {
				refScript.OnDeath();
			}
		}

	}
}