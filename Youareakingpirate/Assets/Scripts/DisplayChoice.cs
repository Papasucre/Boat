using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class DisplayChoice : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
#pragma warning disable 0649
    [SerializeField] int inputNumber;

    [Header("CANVAS")]
    [SerializeField] Canvas masterCanvas;
    [SerializeField] Canvas actionCanvas;
    [SerializeField] Canvas upgradeCanvas;
    [SerializeField] Canvas relicCanvas;

    [Header("UI")]
    [SerializeField] new TextMeshProUGUI name;

    [Header("ACTION")]
    [SerializeField] Image[] actionImgReward = new Image[5];
    [SerializeField] TextMeshProUGUI[] actionTxtReward = new TextMeshProUGUI[5];
    [SerializeField] Image[] actionImgCost = new Image[4];
    [SerializeField] TextMeshProUGUI[] actionTxtCost = new TextMeshProUGUI[4];

    [Header("UPGRADE")]
    [SerializeField] TextMeshProUGUI upgradeNewCapacity;
    [SerializeField] TextMeshProUGUI upgradeGoldCost;

    [Header("RELIC")]
    [SerializeField] TextMeshProUGUI relicDescription;
    [SerializeField] Image[] relicImg = new Image[4];
    [SerializeField] TextMeshProUGUI[] relicTxt = new TextMeshProUGUI[4];
    [SerializeField] TextMeshProUGUI relicGoldCost;

    [Header("IMAGES")]
    [SerializeField] Sprite empty;
    [SerializeField] Sprite sailor;
    [SerializeField] Sprite food;
    [SerializeField] Sprite wood;
    [SerializeField] Sprite gold;
    [SerializeField] Sprite relic;

    [Header("HIGHLIGHT")]
    [SerializeField] Image highlight;
#pragma warning restore 0649

    GraphicRaycaster raycaster;

    void Awake()
    {
        raycaster = GetComponent<GraphicRaycaster>();
    }

    void Update()
    {
        //Check if the left Mouse button is clicked
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Set up the new Pointer Event
            PointerEventData pointerData = new PointerEventData(EventSystem.current);
            List<RaycastResult> results = new List<RaycastResult>();

            //Raycast using the Graphics Raycaster and mouse click position
            pointerData.position = Input.mousePosition;
            raycaster.Raycast(pointerData, results);

            //For every result returned, output the name of the GameObject on the Canvas hit by the Ray
            foreach (RaycastResult result in results)
            {
                switch (inputNumber)
                {
                    case 1:
                        GameManager.instance.input_choice1 = true;
                        return;
                    case 2:
                        GameManager.instance.input_choice2 = true;
                        return;
                    case 3:
                        GameManager.instance.input_choice3 = true;
                        return;
                    default:
                        Debug.LogError("Please configure a input number");
                        break;
                }
            }
        }
    }

    

    public void Display(GameManager.Action item)
    {
        name.text = item.name;
        int i = 0;
        if(item.sailorReward != GameManager.Cost.none)
        {
            actionImgReward[i].sprite = sailor;
            actionTxtReward[i].text = item.sailorReward.ToString();
            i++;
        }
        if (item.foodReward != GameManager.Cost.none)
        {
            actionImgReward[i].sprite = food;
            actionTxtReward[i].text = item.foodReward.ToString();
            i++;
        }
        if (item.woodReward != GameManager.Cost.none)
        {
            actionImgReward[i].sprite = wood;
            actionTxtReward[i].text = item.woodReward.ToString();
            i++;
        }
        if (item.goldReward != GameManager.Cost.none)
        {
            actionImgReward[i].sprite = gold;
            actionTxtReward[i].text = item.goldReward.ToString();
            i++;
        }
        if (item.relicReward != GameManager.Cost.none)
        {
            actionImgReward[i].sprite = relic;
            actionTxtReward[i].text = item.relicReward.ToString();
        }
        i = 0;
        if(item.sailorPrice != GameManager.Cost.none)
        {
            actionImgCost[i].sprite = sailor;
            actionTxtCost[i].text = GameManager.instance.GetSailorsCostWithRelics(item, GameManager.instance.GetSailorCost(item.sailorPrice)).ToString();
            i++;
        }
        if (item.foodPrice != GameManager.Cost.none)
        {
            actionImgCost[i].sprite = food;
            actionTxtCost[i].text = GameManager.instance.GetFoodCostWithRelics(item, GameManager.instance.GetFoodCost(item.foodPrice)).ToString();
            i++;
        }
        if (item.woodPrice != GameManager.Cost.none)
        {
            actionImgCost[i].sprite = wood;
            actionTxtCost[i].text = GameManager.instance.GetWoodCostWithRelics(item, GameManager.instance.GetWoodCost(item.woodPrice)).ToString();
            i++;
        }
        if (item.goldPrice != GameManager.Cost.none)
        {
            actionImgCost[i].sprite = gold;
            actionTxtCost[i].text = GameManager.instance.GetGoldCostWithRelics(item, GameManager.instance.GetGoldCost(item.goldPrice)).ToString();
        }
        masterCanvas.enabled = true;
        actionCanvas.enabled = true;
    }

    public void Display(Upgrade item)
    {
        name.text = item.name;
        upgradeNewCapacity.text = item.newCapacity.ToString();
        upgradeGoldCost.text = GameManager.instance.GetCarpenterGoldCostWithRelics(GameManager.instance.GetGoldCostCarpenter(item.goldPrice)).ToString();
        masterCanvas.enabled = true;
        upgradeCanvas.enabled = true;
    }

    public void Display(GameObject item)
    {
        Relic relicScript = item.GetComponent<Relic>();
        name.text = relicScript.name;
        relicDescription.text = relicScript.description;
        Relic.RelicData[] data = relicScript.GetData();
        for (int i = 0; i < data.Length; i++)
        {
            switch (data[i].resource)
            {
                case GameManager.ResourceType.none:
                    break;
                case GameManager.ResourceType.sailor:
                    relicImg[i].sprite = sailor;
                    break;
                case GameManager.ResourceType.food:
                    relicImg[i].sprite = food;
                    break;
                case GameManager.ResourceType.wood:
                    relicImg[i].sprite = wood;
                    break;
                case GameManager.ResourceType.gold:
                    relicImg[i].sprite = gold;
                    break;
                default:
                    break;
            }
            relicTxt[i].text = data[i].value;
        }
        relicGoldCost.text = GameManager.instance.GetRelicGoldCostWithRelics(relicScript.goldPrice).ToString();
        masterCanvas.enabled = true;
        relicCanvas.enabled = true;
    }

    public void Undisplay()
    {
        masterCanvas.enabled = false;
        actionCanvas.enabled = false;
        upgradeCanvas.enabled = false;
        relicCanvas.enabled = false;
        name.text = "";
        for (int i = 0; i < actionImgReward.Length; i++)
        {
            actionImgReward[i].sprite = empty;
            actionTxtReward[i].text = "";
        }
        for (int i = 0; i < actionImgCost.Length; i++)
        {
            actionImgCost[i].sprite = empty;
            actionTxtCost[i].text = "";
        }
        upgradeNewCapacity.text = "";
        upgradeGoldCost.text = "";
        relicDescription.text = "";
        for (int i = 0; i < relicImg.Length; i++)
        {
            relicImg[i].sprite = empty;
            relicTxt[i].text = "";
        }
        relicGoldCost.text = "";
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        highlight.enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        highlight.enabled = false;
    }
}
