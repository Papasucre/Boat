using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChoiceController : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
#pragma warning disable 0649
    [SerializeField] Text islandName;
    [SerializeField] Text title;
    [SerializeField] Image img1;
    [SerializeField] Text value1;
    [SerializeField] Image img2;
    [SerializeField] Text value2;
    [SerializeField] Image img3;
    [SerializeField] Text value3;
    [SerializeField] Image img4;
    [SerializeField] Text value4;
    [SerializeField] Sprite food;
    [SerializeField] Sprite wood;
    [SerializeField] Sprite gold;
    [SerializeField] Sprite sailor;
    [SerializeField] Sprite empty;
    [SerializeField] Button validate;
#pragma warning restore 0649

    Encounter.RessourcesType ressourceType1;
    Encounter.RessourcesType ressourceType2;
    Encounter.RessourcesType ressourceType3;
    Encounter.RessourcesType ressourceType4;

    Island islandScript;

    private void Start()
    {
        islandScript = GameObject.FindObjectOfType<Island>();
        switch (gameObject.tag)
        {
            case "Choice1":
                islandName.text = islandScript.encounterName;
                title.text = islandScript.choiceName_1;
                UpdateChoice(islandScript.ressource1_1, img1, value1, islandScript.ressource1Value_1, 1);
                UpdateChoice(islandScript.ressource2_1, img2, value2, islandScript.ressource2Value_1, 2);
                UpdateChoice(islandScript.ressource3_1, img3, value3, islandScript.ressource3Value_1, 3);
                UpdateChoice(islandScript.ressource4_1, img4, value4, islandScript.ressource4Value_1, 4);
                break;
            case "Choice2":
                title.text = islandScript.choiceName_2;
                UpdateChoice(islandScript.ressource1_2, img1, value1, islandScript.ressource1Value_2, 1);
                UpdateChoice(islandScript.ressource2_2, img2, value2, islandScript.ressource2Value_2, 2);
                UpdateChoice(islandScript.ressource3_2, img3, value3, islandScript.ressource3Value_2, 3);
                UpdateChoice(islandScript.ressource4_2, img4, value4, islandScript.ressource4Value_2, 4);
                break;
            case "Choice3":
                title.text = islandScript.choiceName_3;
                UpdateChoice(islandScript.ressource1_3, img1, value1, islandScript.ressource1Value_3, 1);
                UpdateChoice(islandScript.ressource2_3, img2, value2, islandScript.ressource2Value_3, 2);
                UpdateChoice(islandScript.ressource3_3, img3, value3, islandScript.ressource3Value_3, 3);
                UpdateChoice(islandScript.ressource4_3, img4, value4, islandScript.ressource4Value_3, 4);
                break;
            default:
                break;
        }
    }

    void UpdateChoice(Encounter.RessourcesType type, Image image, Text text, string value, int emplacement)
    {
        switch (emplacement)
        {
            case 1:
                ressourceType1 = type;
                break;
            case 2:
                ressourceType2 = type;
                break;
            case 3:
                ressourceType3 = type;
                break;
            case 4:
                ressourceType4 = type;
                break;
            default:
                break;
        }
        if (type != Encounter.RessourcesType.none)
        {
            switch (type)
            {
                case Encounter.RessourcesType.none:
                    image.sprite = empty;
                    break;
                case Encounter.RessourcesType.food:
                    image.sprite = food;
                    break;
                case Encounter.RessourcesType.wood:
                    image.sprite = wood;
                    break;
                case Encounter.RessourcesType.gold:
                    image.sprite = gold;
                    break;
                case Encounter.RessourcesType.sailor:
                    image.sprite = sailor;
                    break;
                default:
                    break;
            }
            text.text = value;
        }
        else
        {
            image.sprite = empty;
            text.text = "";
        }
    }

    void ConvertChoiceValue()
    {
        switch (ressourceType1)
        {
            case Encounter.RessourcesType.none:
                break;
            case Encounter.RessourcesType.food:
                GameManager.Instance.choiceFoodValue = int.Parse(value1.text);
                break;
            case Encounter.RessourcesType.wood:
                GameManager.Instance.choiceWoodValue = int.Parse(value1.text); 
                break;
            case Encounter.RessourcesType.gold:
                GameManager.Instance.choiceGoldValue = int.Parse(value1.text);
                break;
            case Encounter.RessourcesType.sailor:
                GameManager.Instance.choiceSailorValue = int.Parse(value1.text);
                break;
            default:
                break;
        }
        switch (ressourceType2)
        {
            case Encounter.RessourcesType.none:
                break;
            case Encounter.RessourcesType.food:
                GameManager.Instance.choiceFoodValue = int.Parse(value2.text);
                break;
            case Encounter.RessourcesType.wood:
                GameManager.Instance.choiceWoodValue = int.Parse(value2.text);
                break;
            case Encounter.RessourcesType.gold:
                GameManager.Instance.choiceGoldValue = int.Parse(value2.text);
                break;
            case Encounter.RessourcesType.sailor:
                GameManager.Instance.choiceSailorValue = int.Parse(value2.text);
                break;
            default:
                break;
        }
        switch (ressourceType3)
        {
            case Encounter.RessourcesType.none:
                break;
            case Encounter.RessourcesType.food:
                GameManager.Instance.choiceFoodValue = int.Parse(value3.text);
                break;
            case Encounter.RessourcesType.wood:
                GameManager.Instance.choiceWoodValue = int.Parse(value3.text);
                break;
            case Encounter.RessourcesType.gold:
                GameManager.Instance.choiceGoldValue = int.Parse(value3.text);
                break;
            case Encounter.RessourcesType.sailor:
                GameManager.Instance.choiceSailorValue = int.Parse(value3.text);
                break;
            default:
                break;
        }

        switch (ressourceType4)
        {
            case Encounter.RessourcesType.none:
                break;
            case Encounter.RessourcesType.food:
                GameManager.Instance.choiceFoodValue = int.Parse(value4.text);
                break;
            case Encounter.RessourcesType.wood:
                GameManager.Instance.choiceWoodValue = int.Parse(value4.text);
                break;
            case Encounter.RessourcesType.gold:
                GameManager.Instance.choiceGoldValue = int.Parse(value4.text);
                break;
            case Encounter.RessourcesType.sailor:
                GameManager.Instance.choiceSailorValue = int.Parse(value4.text);
                break;
            default:
                break;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ConvertChoiceValue();
        validate.gameObject.SetActive(true);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }
}
