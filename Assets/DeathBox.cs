using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
        if (other.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
   }
}
