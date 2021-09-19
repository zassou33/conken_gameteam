using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomPush : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField,HeaderAttribute("�����_���ŏo�閼�O(���p�J���}����)")] string randomNames;
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
