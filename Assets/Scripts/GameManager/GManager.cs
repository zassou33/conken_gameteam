using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class GManager : MonoBehaviour
{
    [SerializeField] Text text;
    public static GManager instance { get; private set; }
    private string _playerName;
    public string PlayerName { get { return _playerName; } 
        set { _playerName = value;text.text = _playerName; } }
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
