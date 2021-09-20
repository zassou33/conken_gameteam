using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameDicideButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] InputField inputField;
    private void Start()
    {
        inputField = inputField.GetComponent<InputField>();
    }
    public void OnClick (){
        GManager.instance.PlayerName = inputField.text;
    }
}
