﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myGUI : MonoBehaviour {

	public Text winLoseText;

	public RectTransform bckGroundRecttransform;
	float rctTransformY;
	public bool gameEnded;
	public bool lose;

	public float rate;

	public Button nextLevelButton;

	public Image youWin;
	public Image youLose;

	// Use this for initialization
	void Start () {
		rctTransformY = 0;
	}
	
	// Update is called once per frame
	void Update () {

		//winAnimation();
		if (lose)
		{
			nextLevelButton.interactable = false;
		}
		else
		{
			nextLevelButton.interactable = true;
		}
		
	}
	public void winAnimation()
	{
		if (lose) youLose.gameObject.SetActive(true);
		else if (!lose) youWin.gameObject.SetActive(true);
	
		//rctTransformY += Time.deltaTime * rate;
		//bckGroundRecttransform.sizeDelta = new Vector2(bckGroundRecttransform.sizeDelta.x, rctTransformY);

		//rctTransformY += Time.deltaTime * rate;
		////increase the scale such that it would look like an animation
		//bckGroundRecttransform.localScale = new Vector3(1, rctTransformY, 1);
	}

	public static void FocusControl(object p)
	{
		throw new NotImplementedException();
	}
}
