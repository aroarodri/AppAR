using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemButtonManager : MonoBehaviour
{
    private string itemName;
    public string ItemName { set => itemName = value; }

    private string itemDescription;
    public string ItemDescription { set => itemDescription = value; }

    private string price;
    public string Price { set => price = value; }

    private Sprite itemImage;
    public Sprite ItemImage { set => itemImage = value; }

    private GameObject item3DModel;
    public GameObject Item3DModel { set => item3DModel = value; }


    [SerializeField] private GameObject floorShadow;
    private GameObject floorShadorScene;

    private ARInteractionManager arInteractionManager;

    private void Start()
    {
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = itemName;
        transform.GetChild(1).GetComponent<RawImage>().texture = itemImage.texture;
        transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = itemDescription;

        var button = GetComponent<Button>();
        button.onClick.AddListener(GameManager.instance.ARPosition);
        button.onClick.AddListener(Create3DModel);

        arInteractionManager = FindObjectOfType<ARInteractionManager>();
    }

    private void Create3DModel()
    {

        floorShadorScene = GameObject.FindGameObjectWithTag("Floor");
        if (floorShadorScene != null)
        {
            arInteractionManager.Item3DModel = Instantiate(floorShadow);
            floorShadow.SetActive(true);
        }
        arInteractionManager.Item3DModel = Instantiate(item3DModel);


    }
}
