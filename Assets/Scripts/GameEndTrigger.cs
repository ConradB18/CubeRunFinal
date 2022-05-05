using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndTrigger : MonoBehaviour
{

    private void OnCollisionEnter(Collision collisionInfo)

    {
		print("Collision");
        if (collisionInfo.gameObject.tag == "Player")
        {	
            FindObjectOfType<GameManager>().LevelComplete();
            FindObjectOfType<PlayerMovement>().enabled = false; 
			
        }
    }
}
