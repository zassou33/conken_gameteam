using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomPush : MonoBehaviour
{
    [SerializeField] string randomNames;
    [SerializeField] InputField inputField;
    private void Start()
    {
        inputField = inputField.GetComponent<InputField>();
    }
    public void OnClick()
    {
        string[] randomArray = randomNames.Split(',');
        inputField.text = randomArray[Random.Range(0, randomArray.Length)];
    }
}
