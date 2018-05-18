using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject item;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(item != null)
         if (item.name == "Key")
            if (Input.GetKeyDown(KeyCode.Space))
                VRTK.VRTK_ConsoleViewer.print("Сломал");
    }
}
