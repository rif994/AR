using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {


	public GameObject menuPanel;
	public GameObject aboutPanel;
	public GameObject exitPanel;
	
	
	// Use this for initialization
	void Start () {
	menuPanel.SetActive(true);
	aboutPanel.SetActive(false);
	exitPanel.SetActive(false);
	}
		
		
	public void StartClicked()
	{
		Application.LoadLevel(1);
	}
	
	public void AboutClicked()
	{
		aboutPanel.SetActive(true);
		menuPanel.SetActive(false);
		exitPanel.SetActive(false);
	}
	
	public void Quit1Clicked()
	{
		Application.Quit();
	}
	
	public void BackToMenuClicked()
	{
		menuPanel.SetActive(true);
		aboutPanel.SetActive(false);
		exitPanel.SetActive(false);
	}
	
	public void Exit1Clicked()
	{
		exitPanel.SetActive(true);
		menuPanel.SetActive(false);
		aboutPanel.SetActive(false);
	}
}
