using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // OnMainMenu
    // OnLibrary
    // OnARPosition

    public event Action OnMainMenu;
    public event Action OnLibrary;
    public event Action OnARPosition;

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        MainMenu();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainMenu()
    {
        Debug.Log("Main Menu");
        OnMainMenu?.Invoke();
    }

    public void Library()
    {
        Debug.Log("Library");
        OnLibrary?.Invoke();
    }

    public void ARPosition()
    {
        Debug.Log("AR Position");
        OnARPosition?.Invoke();
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
