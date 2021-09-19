using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class SceneLoader : MonoBehaviour
{ 
    public enum Scenes
    {
        Title,
        BedTime,
        Eating,
        Main,
        Outing,
        Runking,
        Study,
    }
    [SerializeField] Scenes sceneName;

      public void LoadScene() { 
            SceneManager.LoadScene(Enum.GetName(typeof(Scenes),sceneName));
        }

}