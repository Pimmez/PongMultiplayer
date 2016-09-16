using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class PressTheButton : NetworkBehaviour {

	[SerializeField] private GameObject LobbyManager;
	private GameObject buttonMenu;
	[SerializeField] private GameObject mainMenu;
	[SerializeField] private string buttonToSomething; 
	[SerializeField] private string levelname; 

	void Start()
	{
		LobbyManager = GameObject.Find ("LobbyManager");
		LobbyManager.SetActive (false);
		mainMenu.SetActive (false);
		buttonMenu = GameObject.Find (buttonToSomething);
	}

	public void ToLobby()
	{
		LobbyManager.SetActive (true);
		Debug.Log (LobbyManager);
		mainMenu.SetActive(true);
		SceneManager.LoadScene (levelname);
	}

	public void ReturnToMenu()
	{
		SceneManager.LoadScene (levelname);
		mainMenu.SetActive (false);
		LobbyManager.SetActive (false);
		Debug.Log (LobbyManager);
	
	}

	public void QuitGame()
	{
		Application.Quit();
	}

}
