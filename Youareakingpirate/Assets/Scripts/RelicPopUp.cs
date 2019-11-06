using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RelicPopUp : MonoBehaviour
{
#pragma warning disable 0649
    [Header("IMAGES")]
    [SerializeField] Sprite empty;
    [SerializeField] Sprite sailor;
    [SerializeField] Sprite food;
    [SerializeField] Sprite wood;
    [SerializeField] Sprite gold;
#pragma warning restore 0649

    public TextMeshProUGUI relicName;
    TextMeshProUGUI description;
    Image[] relicImg = new Image[4];
    TextMeshProUGUI[] relicTxt = new TextMeshProUGUI[4];

    private void Start()
    {
        relicName = transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        description = transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>();
        relicImg[0] = transform.GetChild(2).gameObject.GetComponent<Image>();
        relicTxt[0] = transform.GetChild(3).gameObject.GetComponent<TextMeshProUGUI>();
        relicImg[1] = transform.GetChild(4).gameObject.GetComponent<Image>();
        relicTxt[1] = transform.GetChild(5).gameObject.GetComponent<TextMeshProUGUI>();
        relicImg[2] = transform.GetChild(6).gameObject.GetComponent<Image>();
        relicTxt[2] = transform.GetChild(7).gameObject.GetComponent<TextMeshProUGUI>();
        relicImg[3] = transform.GetChild(8).gameObject.GetComponent<Image>();
        relicTxt[3] = transform.GetChild(9).gameObject.GetComponent<TextMeshProUGUI>();
    }

    public void SetData(Relic relicScript)
    {
        for (int i = 0; i < 4; i++)
        {
            relicImg[i].sprite = empty;
            relicTxt[i].text = "";
        }
        relicName.text = relicScript.name;
        description.text = relicScript.description;
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
    }
}
