using DG.Tweening;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject library;
    [SerializeField] private GameObject arPosition;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnMainMenu += ActivateMenu;
        GameManager.instance.OnLibrary += ActiveLibrary;
        GameManager.instance.OnARPosition += ActiveAR;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ActivateMenu()
    {
        mainMenu.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        library.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        library.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        arPosition.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

    }

    private void ActiveLibrary()
    {
        mainMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        library.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        library.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        library.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }

    private void ActiveAR()
    {
        mainMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        library.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        library.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        arPosition.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }


}
