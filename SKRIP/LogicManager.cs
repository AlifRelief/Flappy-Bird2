using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public void Restart()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        Debug.Log("Restarting scene: " + currentSceneName);
        SceneManager.LoadScene(currentSceneName);
    }

    
}
