using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MS : MonoBehaviour {
	
	public void changeScene(int changeScene)
	{
		SceneManager.LoadScene (changeScene);
	}
}
