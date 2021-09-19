using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Data : MonoBehaviour
{
    [SerializeField] private string[] outNames = { "糞", "馬鹿" };
    private string _playerName;
    public string PlayerName
    {
        get
        {
            return _playerName;
        }
        set
        {
            //アウトな名前弾く処理を入れたいです
            _playerName = value;
        }
    }
}


