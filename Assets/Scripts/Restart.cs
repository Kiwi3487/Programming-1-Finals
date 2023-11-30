using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for reloading the scene
public class Restart : MonoBehaviour
{
    public void Restarting()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
    }
}
