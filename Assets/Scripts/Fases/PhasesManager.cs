﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhasesManager : MonoBehaviour
{
    public List<Button> phasesButtons = new List<Button>();
	public List<Image> buttonImages = new List<Image>();
	public List<Sprite> imageSprites = new List<Sprite>();

	private void Start()
	{
		if (!(PlayerPrefs.GetInt("LastPhaseUnlocked") >= 1))
		{
			PlayerPrefs.SetInt("LastPhaseUnlocked", 1); //ajustar aqui qual a primeira fase liberada
		}
	}

	void Update()
    {
  //      for (int i = 0; i < phasesButtons.Count; i++)
		//{
		//	phasesButtons[i].GetComponent<CheckIfPhaseUnlocked>().isLocked = !(PlayerPrefs.GetInt("LastPhaseUnlocked") > i);
		//	buttonImages[i].sprite = (PlayerPrefs.GetInt("LastPhaseUnlocked") > i + 1) ? imageSprites[i] : buttonImages[i].sprite;
		//}
	}

	public void LiberaTerceiraFase()
	{
		PlayerPrefs.SetInt("LastPhaseUnlocked", 3);
	}

	public void ResetaSave()
	{
		PlayerPrefs.DeleteAll();
		PlayerPrefs.SetInt("LastPhaseUnlocked", 1);
	}
}
