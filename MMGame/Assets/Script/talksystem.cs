using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class talksystem : MonoBehaviour {

	[SerializeField] InputField input;
	[SerializeField] RectTransform timeline;
	[SerializeField] RectTransform meFukidashi;
	[SerializeField] RectTransform toFukidashi;
	[SerializeField] Player player;

//	[SerializeField] Text elementOriginalText1;
//	[SerializeField] RectTransform content2;
//	[SerializeField] Text elementOriginalText2;
//	[SerializeField] RectTransform content3;
//	[SerializeField] RectTransform originalElement3;
//	[SerializeField] Text elementOriginalText3;
//	[SerializeField] RectTransform content4;
//	[SerializeField] RectTransform originalElement4;
//	[SerializeField] Text elementOriginalText4;

//	[SerializeField] RectTransform Chat;
//	public GameObject Chat;
//	[SerializeField] Image icon2;

	bool reply1 = true;
	bool reply2 = true;
	bool hint1 = true;

//		void Awake()
//		{
//			originalElement1.gameObject.SetActive (false);
//			originalElement2.gameObject.SetActive (false);
//		}
	
//	public void OnSubmit()
//	{
//		elementOriginalText1.text = input.text;
//		input.text = string.Empty;
//		Fukidashi ();
//	}

	public void OnSubmit()
	{
		string userText = input.text;
		if (userText == "") {
			return;
		}

		input.text = string.Empty;
		CreateFukidashi (meFukidashi, userText);

		if(userText == ("こんにちは") && reply1)
		{
			CreateFukidashi (toFukidashi, "こんばんは");
			player.hasKey1 = true;
			reply1 = false;
		}

		if(userText == ("ありがとう") && player.hasKey1 && reply2) {
			CreateFukidashi (toFukidashi, "どういたしまして");
			player.hasKey2 = true;
			reply2 = false;
		}

		else if (input.text == ("ヒント") && hint1) {
			CreateFukidashi (toFukidashi, "ヒントだよ");
			hint1 = false;
		}

//		Gamereset ();
	}

	void CreateFukidashi(RectTransform fukidashi, string serifu)
	{
		var to = Instantiate (fukidashi);
		to.GetComponentInChildren<Text> ().text = serifu;
		to.SetParent (timeline);
		to.SetAsLastSibling ();
		
//		var element1 = GameObject.Instantiate<RectTransform> (originalElement1);
//		var element2 = GameObject.Instantiate<RectTransform> (originalElement2);

//		element1.SetParent (content1, false);
//		element1.SetAsLastSibling ();
//		element1.gameObject.SetActive (true);
//
//		element2.SetParent (content2, false);
//		element2.SetAsLastSibling ();
//		element2.gameObject.SetActive (true);

//		GameObject c = Instantiate (Chat);
//		c.transform.SetParent (Chat.transform);

	}



//	void Gamereset(){
//		
//		if(input.text == ("リセット")){
//			PlayerPrefs.SetInt ("Key1", 0);
//			PlayerPrefs.SetInt ("Key2", 0);
//			PlayerPrefs.SetInt ("Key3", 0);
//
//
//			SceneManager.LoadScene("MenuScene");
//		}
//	}
}
