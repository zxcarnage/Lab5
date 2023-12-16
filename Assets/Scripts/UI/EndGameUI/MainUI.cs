using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    [SerializeField] private LoseScreen _loseScreen;

    private void Awake()
    {
        ServiceLocator.MainUI = this;
    }

    public void ShowLoseScreen()
    {
        SceneManager.LoadScene(1);
    }
}
