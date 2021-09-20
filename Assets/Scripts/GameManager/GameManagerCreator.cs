using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCreator : MonoBehaviour
{
    private static bool Loaded { get; set; }

    [SerializeField]
    GameObject gameManagerPrefab = null;

    void Awake()
    {
        //���łɃ��[�h�ς݂Ȃ�A��d�ɍ쐬���Ȃ�
        if (Loaded) return;

        Loaded = true;

        //�v���n�u���C���X�^���X�����āADontDestroyOnLoad
            GameObject go = Instantiate(gameManagerPrefab);
            DontDestroyOnLoad(go);
    }
}

