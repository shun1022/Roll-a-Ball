using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour
{

    void OnCollisionEnter(Collision Hit)
    {
        if(Hit.gameObject.CompareTag("Player"))
        {
            int SceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(SceneIndex);
        }
    }

}