using UnityEngine;
using System.Collections;

using UnityEngine.UI; //contains Text and other UI-related classes

public class HelloWorld : MonoBehaviour {

	public Text textObject;

	// Use this for initialization
	void Start () {
		Debug.Log("Hello World!");
	}
	
	// Update is called once per frame
	void Update () {
		textObject.text = (Time.deltaTime / ((float) 1/60)).ToString();
	}
}
