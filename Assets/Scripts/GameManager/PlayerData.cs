using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Data : MonoBehaviour
{
    [SerializeField] private string[] outNames = { "��", "�n��" };
    private string _playerName;
    public string PlayerName
    {
        get
        {
            return _playerName;
        }
        set
        {
            //�A�E�g�Ȗ��O�e����������ꂽ���ł�
            _playerName = value;
        }
    }
}


