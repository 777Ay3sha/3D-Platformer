using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	public void RestartGame ()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(1);
	}
      public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
   
}


