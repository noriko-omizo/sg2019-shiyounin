using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public bool hasKey1;
	public bool hasKey2;
	public bool hasKey3;
		
	void Start () {

		int Key1= PlayerPrefs.GetInt ("Key1", 0);
		if (Key1== 1) {
			hasKey1 = true;

		} 

		int Key2= PlayerPrefs.GetInt ("Key2", 0);
		if (Key2== 1) {
			hasKey2 = true;
		} 

		int Key3= PlayerPrefs.GetInt ("Key3", 0);
		if (Key3== 1) {
			hasKey3 = true;
		} 
	}
}
