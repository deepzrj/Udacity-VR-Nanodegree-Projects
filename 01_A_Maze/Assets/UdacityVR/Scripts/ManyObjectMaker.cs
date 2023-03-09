using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManyObjectMaker : MonoBehaviour {
    public GameObject manyObjectMaker;
	// Use this for initialization
	void Start () {
        for (int i=0;i<1000;i++)
        {
            Object.Instantiate(manyObjectMaker,new Vector3(i, i, i), Quaternion.identity);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
