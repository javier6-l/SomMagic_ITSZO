using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RAButtonEvent : MonoBehaviour
{
	public Button boton;
	public GameObject subRA;
	public GameObject manager;
	public TextMeshProUGUI textMeshProUGUI;
	public string texto;
	public AudioClip clip;
	//public Button BCerroSombreretillo;
	//public Button BCatrinaIterante;

	void Start()
	{
		Button bfp = boton.GetComponent<Button>();
		bfp.onClick.AddListener(TaskOnClick);

		//textMeshProUGUI = subrageneral.GetComponent<TextMeshProUGUI>();
		//Button bcs = BfantasmaPuente.GetComponent<Button>();
		//bcs.onClick.AddListener(TaskOnClick);

		//Button bci = BfantasmaPuente.GetComponent<Button>();
		//bci.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		subRA.GetComponentInChildren<AudioSource>().clip = clip;
		textMeshProUGUI.text = texto;
		manager.GetComponent<GameManager>().UIRA();
		Debug.Log("You have clicked the button!");
	}
}
