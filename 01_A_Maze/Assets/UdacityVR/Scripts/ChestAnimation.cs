using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.

public class ChestAnimation : MonoBehaviour {
    public GameObject chest;
    private Animation chestAnimation;

	// Use this for initialization
	void Start () {
        chestAnimation = chest.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnChestClicked()

    {
        Debug.Log("'ChestAnimation.OnChestClicked()' was called");
        chestAnimation.Play();
    }
}
