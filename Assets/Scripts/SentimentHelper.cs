using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentimentHelper : MonoBehaviour {
    public Material sadMaterial;
    public Material happyMaterial;
    public Material angryMaterial;

    public Renderer renderer;

    // public Transform 
	// Use this for initialization
	void Start () {
        renderer = gameObject.GetComponent<Renderer>();
	}
	
	//// Update is called once per frame
	//void Update () {
		
	//}

    public void makeHappy() {
        renderer.material = happyMaterial;
    }

    public void makeSad() {
        renderer.material = sadMaterial;
    }

    public void makeAngry() {
        renderer.material = angryMaterial;
    }
}
