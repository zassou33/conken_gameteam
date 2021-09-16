using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonPush : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    // Start is called before the first frame update
    public void OnClick()
    {
        panel.SetActive(true);
    }
}
