using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StudyButtonPush : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        SceneManager.LoadScene("Study");
    }
}
