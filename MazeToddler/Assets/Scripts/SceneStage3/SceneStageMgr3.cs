﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneStageMgr3 : MonoBehaviour {

    //RuntimePlatform platform = Application.platform;

    public void OnBtnResult()
    {
        Application.LoadLevel("SceneResult");
    }

    /*
	public void OnQuitBtn()
	{
		Application.Quit();
	}

	void Update()
	{
		if( platform == RuntimePlatform.Android)
		{
			if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); }
		}
	}
	*/
}
