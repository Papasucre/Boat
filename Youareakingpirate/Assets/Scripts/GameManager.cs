using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public DisplayChoice choice1;
    public DisplayChoice choice2;
    public DisplayChoice choice3;
    public GameObject relic;
    public Action action;
    public Upgrade upgrade;

    #region STOCK VARIABLES
    [Header("STOCK")]
    public int sailorsStock;
    public int sailorsMaxStock;
    public int foodStock;
    public int foodMaxStock;
    public int woodStock;
    public int woodMaxStock;
    public int goldStock;
    public int goldMaxStock;
    #endregion

    #region VALUES
#pragma warning disable 0649
    [Header("Sailor")]
    [Header("COST")]
    [SerializeField] int lvl1_lowSailorCost;
    [SerializeField] int lvl1_mediumSailorCost;
    [SerializeField] int lvl1_highSailorCost;
    [SerializeField] int lvl2_lowSailorCost;
    [SerializeField] int lvl2_mediumSailorCost;
    [SerializeField] int lvl2_highSailorCost;
    [SerializeField] int lvl3_lowSailorCost;
    [SerializeField] int lvl3_mediumSailorCost;
    [SerializeField] int lvl3_highSailorCost;
    [Header("Food")]
    [SerializeField] int lvl1_lowFoodCost;
    [SerializeField] int lvl1_mediumFoodCost;
    [SerializeField] int lvl1_highFoodCost;
    [SerializeField] int lvl2_lowFoodCost;
    [SerializeField] int lvl2_mediumFoodCost;
    [SerializeField] int lvl2_highFoodCost;
    [SerializeField] int lvl3_lowFoodCost;
    [SerializeField] int lvl3_mediumFoodCost;
    [SerializeField] int lvl3_highFoodCost;
    [Header("Wood")]
    [SerializeField] int lvl1_lowWoodCost;
    [SerializeField] int lvl1_mediumWoodCost;
    [SerializeField] int lvl1_highWoodCost;
    [SerializeField] int lvl2_lowWoodCost;
    [SerializeField] int lvl2_mediumWoodCost;
    [SerializeField] int lvl2_highWoodCost;
    [SerializeField] int lvl3_lowWoodCost;
    [SerializeField] int lvl3_mediumWoodCost;
    [SerializeField] int lvl3_highWoodCost;
    [Header("Gold")]
    [SerializeField] int lvl1_lowGoldCost;
    [SerializeField] int lvl1_mediumGoldCost;
    [SerializeField] int lvl1_highGoldCost;
    [SerializeField] int lvl2_lowGoldCost;
    [SerializeField] int lvl2_mediumGoldCost;
    [SerializeField] int lvl2_highGoldCost;
    [SerializeField] int lvl3_lowGoldCost;
    [SerializeField] int lvl3_mediumGoldCost;
    [SerializeField] int lvl3_highGoldCost;

    [Header("Sailor")]
    [Header("REWARD")]
    [SerializeField] int lvl1_lowSailorMIN;
    [SerializeField] int lvl1_lowSailorMAX;
    [SerializeField] int lvl1_mediumSailorMIN;
    [SerializeField] int lvl1_mediumSailorMAX;
    [SerializeField] int lvl1_highSailorMIN;
    [SerializeField] int lvl1_highSailorMAX;
    [SerializeField] int lvl2_lowSailorMIN;
    [SerializeField] int lvl2_lowSailorMAX;
    [SerializeField] int lvl2_mediumSailorMIN;
    [SerializeField] int lvl2_mediumSailorMAX;
    [SerializeField] int lvl2_highSailorMIN;
    [SerializeField] int lvl2_highSailorMAX;
    [SerializeField] int lvl3_lowSailorMIN;
    [SerializeField] int lvl3_lowSailorMAX;
    [SerializeField] int lvl3_mediumSailorMIN;
    [SerializeField] int lvl3_mediumSailorMAX;
    [SerializeField] int lvl3_highSailorMIN;
    [SerializeField] int lvl3_highSailorMAX;
    [Header("Food")]
    [SerializeField] int lvl1_lowFoodMIN;
    [SerializeField] int lvl1_lowFoodMAX;
    [SerializeField] int lvl1_mediumFoodMIN;
    [SerializeField] int lvl1_mediumFoodMAX;
    [SerializeField] int lvl1_highFoodMIN;
    [SerializeField] int lvl1_highFoodMAX;
    [SerializeField] int lvl2_lowFoodMIN;
    [SerializeField] int lvl2_lowFoodMAX;
    [SerializeField] int lvl2_mediumFoodMIN;
    [SerializeField] int lvl2_mediumFoodMAX;
    [SerializeField] int lvl2_highFoodMIN;
    [SerializeField] int lvl2_highFoodMAX;
    [SerializeField] int lvl3_lowFoodMIN;
    [SerializeField] int lvl3_lowFoodMAX;
    [SerializeField] int lvl3_mediumFoodMIN;
    [SerializeField] int lvl3_mediumFoodMAX;
    [SerializeField] int lvl3_highFoodMIN;
    [SerializeField] int lvl3_highFoodMAX;
    [Header("Wood")]
    [SerializeField] int lvl1_lowWoodMIN;
    [SerializeField] int lvl1_lowWoodMAX;
    [SerializeField] int lvl1_mediumWoodMIN;
    [SerializeField] int lvl1_mediumWoodMAX;
    [SerializeField] int lvl1_highWoodMIN;
    [SerializeField] int lvl1_highWoodMAX;
    [SerializeField] int lvl2_lowWoodMIN;
    [SerializeField] int lvl2_lowWoodMAX;
    [SerializeField] int lvl2_mediumWoodMIN;
    [SerializeField] int lvl2_mediumWoodMAX;
    [SerializeField] int lvl2_highWoodMIN;
    [SerializeField] int lvl2_highWoodMAX;
    [SerializeField] int lvl3_lowWoodMIN;
    [SerializeField] int lvl3_lowWoodMAX;
    [SerializeField] int lvl3_mediumWoodMIN;
    [SerializeField] int lvl3_mediumWoodMAX;
    [SerializeField] int lvl3_highWoodMIN;
    [SerializeField] int lvl3_highWoodMAX;
    [Header("Gold")]
    [SerializeField] int lvl1_lowGoldMIN;
    [SerializeField] int lvl1_lowGoldMAX;
    [SerializeField] int lvl1_mediumGoldMIN;
    [SerializeField] int lvl1_mediumGoldMAX;
    [SerializeField] int lvl1_highGoldMIN;
    [SerializeField] int lvl1_highGoldMAX;
    [SerializeField] int lvl2_lowGoldMIN;
    [SerializeField] int lvl2_lowGoldMAX;
    [SerializeField] int lvl2_mediumGoldMIN;
    [SerializeField] int lvl2_mediumGoldMAX;
    [SerializeField] int lvl2_highGoldMIN;
    [SerializeField] int lvl2_highGoldMAX;
    [SerializeField] int lvl3_lowGoldMIN;
    [SerializeField] int lvl3_lowGoldMAX;
    [SerializeField] int lvl3_mediumGoldMIN;
    [SerializeField] int lvl3_mediumGoldMAX;
    [SerializeField] int lvl3_highGoldMIN;
    [SerializeField] int lvl3_highGoldMAX;

    [Header("FOOD CONSUMPTION")]
    [SerializeField] int lvl1_foodConsumption;
    [SerializeField] int lvl2_foodConsumption;
    [SerializeField] int lvl3_foodConsumption;
#pragma warning restore 0649
    #endregion

    #region GAME INFORMATIONS
    [Header("GAME INFORMATIONS")]
    public int encounterCounter = 1;
    public GameLevel currentLevel;
    public BoatLevel currentBoat;
    public List<Action> choicesList = new List<Action>();
    public Upgrade[] choicesUpgradeArray = new Upgrade[3];
    public bool makeChoice;
    public bool atCarpenterWorkshop;
    public bool alliesGift;
    public bool canSkip;
    public List<GameObject> relicsEquipped = new List<GameObject>();
    public List<GameObject> cursesEquipped = new List<GameObject>();
    public GameObject[] carpenterRelics = new GameObject[3];
    #endregion

    #region RELICS VARIABLES
    [Header("GENERAL RELICS VARIABLES")]
    public int relicSailorCost;
    public int relicFoodCost;
    public int relicWoodCost;
    public int relicGoldCost;
    public int relicSailorReward;
    public int relicFoodReward;
    public int relicWoodReward;
    public int relicGoldReward;
    public int relicFoodConsumption;
    public int relicWoodConsumption;

    [Header("SPECIFIC RELICS VARIABLES")]
    //RUN AWAY
    public int runAwayWoodCost;
    //HARVEST
    public int harvestGoldReward;
    public int harvestWoodReward;
    public int harvestFoodReward;
    //FIGHT
    public int fightSailorsCost;
    public int fightWoodCost;
    public int fightFoodReward;
    public int fightWoodReward;
    public int fightGoldReward;
    //OTHER
    public int famousExplorerReward;
    public int famousExplorerCounter;
    public int luckyCloverSailor;
    public int luckyCloverFood;
    public int luckyCloverWood;
    public int luckyCloverGold;
    public int lifeInsuranceRevenue;
    public int merchantGoldCost;

    [Header("BOOLEAN RELICS")]
    public bool bloodHunter;
    public bool ghuunLegacy;
    public bool famousExplorer;
    public bool luckyClover;
    public bool lifeInsurance;
    public bool carpenterHammer;
    public bool monkeysPaw;

    bool monkeysPawTried;
    #endregion

    #region SCRIPTS VARIABLES
    RelicsTable relicsScript;
    RandomEncounter randomEncounterScript;
    IslandsTable islandsTableScript;
    ShipsTable shipsTableScript;
    CarpenterDataTable carpenterScript;
    #endregion

    public static GameManager instance;
    public static GameManager Instance {
        get {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        print(Instance);
        ShowRessources();
        if (GameManager.instance != this)
            Destroy(gameObject);
    }

    private void Start()
    {
        relicsScript = GetComponent<RelicsTable>();
        randomEncounterScript = GetComponent<RandomEncounter>();
        carpenterScript = GetComponent<CarpenterDataTable>();
        islandsTableScript = GetComponent<IslandsTable>();
        shipsTableScript = GetComponent<ShipsTable>();
        //randomEncounterScript.LoadRandomEncounter();
        choice1.Display(relic);
        choice2.Display(action);
        choice3.Display(upgrade);
    }

    private void Update()
    {
        if (makeChoice)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (atCarpenterWorkshop)
                {
                    if(choicesUpgradeArray[0] != null)
                    {
                        if (SimulateCarpenterCost(choicesUpgradeArray[0]))
                        {
                            ValidateCarpenterUpgrade(0);
                        }
                        else
                        {
                            print("You cannot take this choice, you don't have enough gold.");
                        }
                    }else if (carpenterRelics[0] != null)
                    {
                        if(goldStock - carpenterRelics[0].GetComponent<Relic>().goldPrice >= 0)
                        {
                            ValidateCarpenterRelic(0,true);
                        }
                        else
                        {
                            print("You don't have enough gold to buy this relic.");
                        }
                        
                    }
                    else
                    {
                        Debug.LogError("How do you came here ?!");
                    }
                }
                else if (SimulateCost(choicesList[0]))
                {
                    if(choicesList[0].ID == "RemoveCurse")
                    {
                        if(cursesEquipped.Count != 0)
                        {
                            ValidateChoice(0);
                        }
                        else
                        {
                            print("You have no curse to remove.");
                        }
                    }
                    else
                        ValidateChoice(0);
                }
                else
                {
                    switch (choicesList[0].ID)
                    {
                        case "RunningAway":
                            if (bloodHunter)
                                print("You cannot run away because of Blood Hunter relic.");
                            else if (ghuunLegacy)
                                print("You cannot run away because of G'huun curse !");
                            else
                                print("You cannot take this choice, you don't have enough ressources.");
                            break;
                        default:
                            print("You cannot take this choice, you don't have enough ressources.");
                            break;
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                if (atCarpenterWorkshop)
                {
                    if (choicesUpgradeArray[1] != null)
                    {
                        if (SimulateCarpenterCost(choicesUpgradeArray[1]))
                        {
                            ValidateCarpenterUpgrade(1);
                        }
                        else
                        {
                            print("You cannot take this choice, you don't have enough gold.");
                        }
                    }
                    else if (carpenterRelics[1] != null)
                    {
                        if (goldStock - carpenterRelics[1].GetComponent<Relic>().goldPrice >= 0)
                        {
                            ValidateCarpenterRelic(1, true);
                        }
                        else
                        {
                            print("You don't have enough gold to buy this relic.");
                        }
                    }
                    else
                    {
                        Debug.LogError("How do you came here ?!");
                    }
                }
                else if (SimulateCost(choicesList[1]))
                {
                    ValidateChoice(1);
                }
                else
                {
                    switch (choicesList[1].ID)
                    {
                        case "RunningAway":
                            if (bloodHunter)
                                print("You cannot run away because of Blood Hunter relic.");
                            else if (ghuunLegacy)
                                print("You cannot run away because of G'huun curse !");
                            else
                                print("You cannot take this choice, you don't have enough ressources.");
                            break;
                        default:
                            print("You cannot take this choice, you don't have enough ressources.");
                            break;
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha3) && (choicesList.Count == 3 || choicesUpgradeArray.Length == 3))
            {
                if (atCarpenterWorkshop || alliesGift)
                {
                    if (choicesUpgradeArray[2] != null)
                    {
                        if (SimulateCarpenterCost(choicesUpgradeArray[2]) || alliesGift)
                        {
                            ValidateCarpenterUpgrade(2);
                        }
                        else
                        {
                            print("You cannot take this choice, you don't have enough gold.");
                        }
                    }
                    else if (carpenterRelics[2] != null)
                    {
                        if (goldStock - carpenterRelics[2].GetComponent<Relic>().goldPrice >= 0 || alliesGift)
                        {
                            ValidateCarpenterRelic(2, !alliesGift);
                        }
                        else
                        {
                            print("You don't have enough gold to buy this relic.");
                        }
                    }
                    else
                    {
                        Debug.LogError("How do you came here ?!");
                    }
                }
                else if (SimulateCost(choicesList[2]))
                {
                    ValidateChoice(2);
                }
                else
                {
                    switch (choicesList[0].ID)
                    {
                        case "RunningAway":
                            if (bloodHunter)
                                print("You cannot run away because of Blood Hunter relic.");
                            else if (ghuunLegacy)
                                print("You cannot run away because of G'huun curse !");
                            else
                                print("You cannot take this choice, you don't have enough ressources.");
                            break;
                        default:
                            print("You cannot take this choice, you don't have enough ressources.");
                            break;
                    }
                }
            }
            if(Input.GetKeyDown(KeyCode.Alpha4) && canSkip)
            {
                print("You choose to skip this encounter.");
                makeChoice = false;
                atCarpenterWorkshop = false;
                StartCoroutine(LoadNextEncounter());
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    #region CARPENTER
    bool SimulateCarpenterCost(Upgrade item)
    {
        if (!carpenterHammer)
        {
            int goldCost = GetGoldCostCarpenter(item.goldPrice);
            if (goldCost != 0)
            {
                relicGoldCost += merchantGoldCost;
                int goldRes = goldCost + relicGoldCost;
                relicGoldCost -= merchantGoldCost;
                if (goldRes > 0)
                {
                    if ((goldStock - goldRes) < 0)
                        return false;
                }
            }
        }
        return true;
    }

    void ValidateCarpenterRelic(int input, bool pay)
    {
        if (pay)
        {
            int goldCost = carpenterRelics[input].GetComponent<Relic>().goldPrice;
            if (goldCost != 0)
            {
                int goldRes = goldCost + relicGoldCost;
                if (goldRes > 0)
                {
                    goldStock -= goldRes;
                }
            }
            else
                Debug.LogError("You shoudln't have to pay a free relic, there is an error somewhere.");
        }
        alliesGift = false;
        relicsEquipped.Add(carpenterRelics[input]);
        if(carpenterRelics[input].GetComponent<Relic>().curse)
            cursesEquipped.Add(carpenterRelics[input]);
        relicsScript.RemoveGainedRelic(carpenterRelics[input]);
        carpenterRelics[input].GetComponent<Relic>().Equip();
        print("You have a new " + (carpenterRelics[input].GetComponent<Relic>().curse ? "curse :" : "relic :"));
        print(carpenterRelics[input].GetComponent<Relic>().description);
        if (luckyClover)
            LuckyClover();
        ShowRessources();
        StartCoroutine(LoadNextEncounter());
    }

    void ValidateCarpenterUpgrade(int input)
    {
        print("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        print("You choose " + choicesUpgradeArray[input].name);
        atCarpenterWorkshop = false;
        if (!alliesGift || !carpenterHammer)
        {
            int goldCost = GetGoldCostCarpenter(choicesUpgradeArray[input].goldPrice);
            if (goldCost != 0)
            {
                relicGoldCost += merchantGoldCost;
                int goldRes = goldCost + relicGoldCost;
                relicGoldCost -= merchantGoldCost;
                if (goldRes > 0)
                {
                    goldStock -= goldRes;
                }
            }
        }
        if (carpenterHammer && !alliesGift)
        {
            UnequipRelic("Carpenter's Hammer", false);
        }
        alliesGift = false;
        ApplyUpgrade(choicesUpgradeArray[input]);
        ShowRessources();
        StartCoroutine(LoadNextEncounter());
    }

    public void CleanCarpenterRelics()
    {
        for (int i = 0; i < carpenterRelics.Length; i++)
        {
            carpenterRelics[i] = null;
        }
    }

    public void CleanUpgradeArray()
    {
        for (int i = 0; i < choicesUpgradeArray.Length; i++)
        {
            choicesUpgradeArray[i] = null;
        }
    }

    void ApplyUpgrade(Upgrade upgrade)
    {
        carpenterScript.UpgradePurchase();
        carpenterScript.SetBoolState(upgrade.ID, true);
        switch (upgrade.ID)
        {
            case "US_01":
                sailorsMaxStock = upgrade.newCapacity;
                carpenterScript.SetBoolState("US_02", false);
                break;
            case "US_02":
                sailorsMaxStock = upgrade.newCapacity;
                break;
            case "UF_01":
                foodMaxStock = upgrade.newCapacity;
                carpenterScript.SetBoolState("UF_02", false);
                break;
            case "UF_02":
                foodMaxStock = upgrade.newCapacity;
                break;
            case "UW_01":
                woodMaxStock = upgrade.newCapacity;
                carpenterScript.SetBoolState("UW_02", false);
                break;
            case "UW_02":
                woodMaxStock = upgrade.newCapacity;
                break;
            case "UG_01":
                goldMaxStock = upgrade.newCapacity;
                carpenterScript.SetBoolState("UG_02", false);
                break;
            case "UG_02":
                goldMaxStock = upgrade.newCapacity;
                break;
            default:
                break;
        }
    }
    #endregion

    #region CLASSIC ACTION
    void ValidateChoice(int input)
    {
        print("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        print("You choose " + choicesList[input].name);
        makeChoice = false;
        switch (choicesList[input].ID)
        {
            case "Is_01"://HARVEST FOOD
                ApplyCost(choicesList[input]);
                relicFoodReward += harvestFoodReward;
                ApplyReward(choicesList[input]);
                relicFoodReward -= harvestFoodReward;
                break;
            case "Is_02"://HARVEST WOOD
                ApplyCost(choicesList[input]);
                relicWoodReward += harvestWoodReward;
                ApplyReward(choicesList[input]);
                relicWoodReward -= harvestWoodReward;
                break;
            case "Is_03"://HARVEST GOLD
                ApplyCost(choicesList[input]);
                relicGoldReward += harvestGoldReward;
                ApplyReward(choicesList[input]);
                relicGoldReward -= harvestGoldReward;
                break;
            case "Is_05"://CARPENTER WORKSHOP
                carpenterScript.AtCarpenter();
                return;
            case "Fight":
                relicSailorCost += fightSailorsCost;
                relicWoodCost += fightWoodCost;
                ApplyCost(choicesList[input]);
                relicSailorCost -= fightSailorsCost;
                relicWoodCost -= fightWoodCost;
                relicFoodReward += fightFoodReward;
                relicWoodReward += fightWoodReward;
                relicGoldReward += fightGoldReward;
                ApplyReward(choicesList[input]);
                relicFoodReward -= fightFoodReward;
                relicWoodReward -= fightWoodReward;
                relicGoldReward -= fightGoldReward;
                break;
            case "Merchant":
                relicGoldCost += merchantGoldCost;
                ApplyCost(choicesList[input]);
                relicGoldCost -= merchantGoldCost;
                ApplyReward(choicesList[input]);
                break;
            case "RemoveCurse":
                GameObject curse = cursesEquipped[Random.Range(0, cursesEquipped.Count)];
                UnequipRelic(curse, true);
                relicGoldCost += merchantGoldCost;
                ApplyCost(choicesList[input]);
                relicGoldCost -= merchantGoldCost;
                ApplyReward(choicesList[input]);
                break;
            case "RunningAway":
                relicWoodCost += runAwayWoodCost;
                ApplyCost(choicesList[input]);
                relicWoodCost -= runAwayWoodCost;
                ApplyReward(choicesList[input]);
                break;
            case "Ignore":
                StartCoroutine(LoadNextEncounter());
                break;
            case "UnknownDiscover":
                shipsTableScript.UnknownDiscover();
                switch (choicesList[input].ID2)
                {
                    case "Fight":
                        relicSailorCost += fightSailorsCost;
                        ApplyCost(choicesList[input]);
                        relicSailorCost -= fightSailorsCost;
                        relicFoodReward += fightFoodReward;
                        relicWoodReward += fightWoodReward;
                        relicGoldReward += fightGoldReward;
                        ApplyReward(choicesList[input]);
                        relicFoodReward -= fightFoodReward;
                        relicWoodReward -= fightWoodReward;
                        relicGoldReward -= fightGoldReward;
                        break;
                    default:
                        ApplyCost(choicesList[input]);
                        ApplyReward(choicesList[input]);
                        break;
                }
                break;
            default:
                ApplyCost(choicesList[input]);
                ApplyReward(choicesList[input]);
                break;
        }
        CheckStock();
        ShowRessources();
        StartCoroutine(LoadNextEncounter());
    }

    bool SimulateCost(Action item)
    {
        switch (item.ID)
        {
            case "RunningAway":
                if (bloodHunter || ghuunLegacy)
                    return false;
                break;
            default:
                break;
        }
        //SAILOR
        switch (item.ID)
        {
            case "Fight":
                int fight_sailorsCost = GetSailorCost(item.sailorPrice);
                if(fight_sailorsCost != 0)
                {
                    relicSailorCost += fightSailorsCost;
                    relicWoodCost += fightWoodCost;
                    int fight_sailorsRes = fight_sailorsCost + relicSailorCost;
                    relicSailorCost -= fightSailorsCost;
                    relicWoodCost -= fightWoodCost;
                    if (fight_sailorsRes > 0)
                    {
                        if ((sailorsStock - fight_sailorsRes) <= 0)
                            return false;
                    }
                }                
                break;
            case "UnknownDiscover":
                switch (item.ID2)
                {
                    case "Fight":
                        int unknown_sailorsCost = GetSailorCost(item.sailorPrice);
                        if (unknown_sailorsCost != 0)
                        {
                            relicSailorCost += fightSailorsCost;
                            relicWoodCost += fightWoodCost;
                            int unknown_sailorsRes = unknown_sailorsCost + relicSailorCost;
                            relicSailorCost -= fightSailorsCost;
                            relicWoodCost -= fightWoodCost;
                            if (unknown_sailorsRes > 0)
                            {
                                if ((sailorsStock - unknown_sailorsRes) <= 0)
                                    return false;
                            }
                        }
                        break;
                    default:
                        int unknownDef_sailorsCost = GetSailorCost(item.sailorPrice);
                        if (unknownDef_sailorsCost != 0)
                        {
                            int unknownDef_sailorsRes = unknownDef_sailorsCost + relicSailorCost;
                            if (unknownDef_sailorsRes > 0)
                            {
                                if ((sailorsStock - unknownDef_sailorsRes) <= 0)
                                    return false;
                            }
                        }
                        break;
                }
                break;
            default:
                int sailorsCost = GetSailorCost(item.sailorPrice);
                if (sailorsCost != 0)
                {
                    int sailorsRes = sailorsCost + relicSailorCost;
                    if (sailorsRes > 0)
                    {
                        if ((sailorsStock - sailorsRes) <= 0)
                            return false;
                    }
                }
                break;
        }
        //FOOD
        int foodCost = GetFoodCost(item.foodPrice);
        if (foodCost != 0)
        {
            int foodRes = foodCost + relicFoodCost;
            if (foodRes > 0)
            {
                if ((foodStock - foodRes) < 0)
                    return false;
            }
        }
        //WOOD
        switch (item.ID)
        {
            case "RunningAway":
                int runningAway_woodCost = GetWoodCost(item.woodPrice);
                if (runningAway_woodCost != 0)
                {
                    relicWoodCost += runAwayWoodCost;
                    int runningAway_woodRes = runningAway_woodCost + relicWoodCost;
                    relicWoodCost -= runAwayWoodCost;
                    if (runningAway_woodRes > 0)
                    {
                        if ((woodStock - runningAway_woodRes) < 0)
                            return false;
                    }
                }
                break;
            default:
                int woodCost = GetWoodCost(item.woodPrice);
                if (woodCost != 0)
                {
                    int woodRes = woodCost + relicWoodCost;
                    if (woodRes > 0)
                    {
                        if ((woodStock - woodRes) < 0)
                            return false;
                    }
                }
                break;
        }
        //GOLD
        switch (item.ID)
        {
            case "Is_05"://CARPENTER WORKSHOP
                if (carpenterHammer)
                    break;
                int carpenter_goldCost = GetGoldCost(item.goldPrice);
                if (carpenter_goldCost != 0)
                {
                    relicGoldCost += merchantGoldCost;
                    int carpenter_goldRes = carpenter_goldCost + relicGoldCost;
                    relicGoldCost -= merchantGoldCost;
                    if (carpenter_goldRes > 0)
                    {
                        if ((goldStock - carpenter_goldRes) < 0)
                            return false;
                    }
                }
                break;
            case "Merchant":
                int merchant_goldCost = GetGoldCost(item.goldPrice);
                if (merchant_goldCost != 0)
                {
                    relicGoldCost += merchantGoldCost;
                    int merchant_goldRes = merchant_goldCost + relicGoldCost;
                    relicGoldCost -= merchantGoldCost;
                    if (merchant_goldRes > 0)
                    {
                        if ((goldStock - merchant_goldRes) < 0)
                            return false;
                    }
                }
                break;
            case "RemoveCurse":
                int removeCurse_goldCost = GetGoldCost(item.goldPrice);
                if (removeCurse_goldCost != 0)
                {
                    relicGoldCost += merchantGoldCost;
                    int removeCurse_goldRes = removeCurse_goldCost + relicGoldCost;
                    relicGoldCost -= merchantGoldCost;
                    if (removeCurse_goldRes > 0)
                    {
                        if ((goldStock - removeCurse_goldRes) < 0)
                            return false;
                    }
                }
                break;
            default:
                int goldCost = GetGoldCost(item.goldPrice);
                if (goldCost != 0)
                {
                    int goldRes = goldCost + relicGoldCost;
                    if (goldRes > 0)
                    {
                        if ((goldStock - goldRes) < 0)
                            return false;
                    }
                }
                break;
        }
        return true;
    }

    void ApplyCost(Action item)
    {
        int sailorsCost = GetSailorCost(item.sailorPrice);
        if(sailorsCost != 0)
        {
            int sailorsRes = sailorsCost + relicSailorCost;
            if(sailorsRes > 0)
            {
                sailorsStock -= sailorsRes;
                if (lifeInsurance)
                {
                    int result = sailorsRes * lifeInsuranceRevenue;
                    goldStock += result;
                    if (goldStock > goldMaxStock)
                        goldStock = goldMaxStock;
                    print("You earn the insurance from " + sailorsRes + " sailor(s), deep condolences");
                }
            }
        }  
        int foodCost = GetFoodCost(item.foodPrice);
        if(foodCost != 0)
        {
            int foodRes = foodCost + relicFoodCost;
            if(foodRes > 0)
            {
                foodStock -= foodRes;
            }
        }
        int woodCost = GetWoodCost(item.woodPrice);
        if(woodCost != 0)
        {
            int woodRes = woodCost + relicWoodCost;
            if (woodRes > 0)
            {
                woodStock -= woodRes;
            }
        }
        int goldCost = GetGoldCost(item.goldPrice);
        if(goldCost != 0)
        {
            int goldRes = goldCost + relicGoldCost;
            if (goldRes > 0)
            {
                goldStock -= goldRes;
            }
        }
    }

    void ApplyReward(Action item)
    {
        int sailorsGain = GetSailorReward(item.sailorReward);
        if(sailorsGain != 0)
        {
            if (monkeysPaw && !monkeysPawTried)
                MonkeysPaw();
            int sailorsRes = sailorsGain + relicSailorReward;
            if(sailorsRes > 0)
            {
                sailorsStock += sailorsRes;
            }
        }
        int foodGain = GetFoodReward(item.foodReward);
        if (foodGain != 0)
        {
            if (monkeysPaw && !monkeysPawTried)
                MonkeysPaw();
            int foodRes = foodGain + relicFoodReward;
            if (foodRes > 0)
            {
                foodStock += foodRes;
            }
        }
        int woodGain = GetWoodReward(item.woodReward);
        if (woodGain != 0)
        {
            if (monkeysPaw && !monkeysPawTried)
                MonkeysPaw();
            int woodRes = woodGain + relicWoodReward;
            if (woodRes > 0)
            {
                woodStock += woodRes;
            }
        }
        int goldGain = GetGoldReward(item.goldReward);
        if (goldGain != 0)
        {
            if (monkeysPaw && !monkeysPawTried)
                MonkeysPaw();
            int goldRes = goldGain + relicGoldReward;
            if (goldRes > 0)
            {
                goldStock += goldRes;
            }
        }
        if (sailorsStock > sailorsMaxStock)
            sailorsStock = sailorsMaxStock;
        if (foodStock > foodMaxStock)
            foodStock = foodMaxStock;
        if (woodStock > woodMaxStock)
            woodStock = woodMaxStock;
        if (goldStock > goldMaxStock)
            goldStock = goldMaxStock;
        if(item.relicReward != Cost.none)
        {
            GameObject relic = GetRelicReward(item.relicReward, item.relicType, item.includeCurse);
            if (relic == null)
            {
                print("Sorry you should have won a " + (item.includeCurse ? "relic (or a curse)" : "relic") + " but there are no more here.");
            }
            else
            {
                Relic relicScript = relic.GetComponent<Relic>();
                relicsEquipped.Add(relic);
                if (relicScript.curse)
                    cursesEquipped.Add(relic);
                relicsScript.RemoveGainedRelic(relic);
                relicScript.Equip();
                print("You have a new " + (relicScript.curse ? "curse :" : "relic :"));
                print(relicScript.name);
                print(relicScript.description);
                if (luckyClover)
                    LuckyClover();
            }
        }
    }
    #endregion

    public void FoodConsumption()
    {
        GameManager.instance.canSkip = false;
        switch (currentLevel)
        {
            case GameLevel.lvl1:
                if (lvl1_foodConsumption + relicFoodConsumption <= 0)
                    break;
                if(foodStock - (lvl1_foodConsumption + relicFoodConsumption) == 0)
                {
                    foodStock = 0;
                    print("You ate your last rations when you got here.");
                }else if(foodStock - (lvl1_foodConsumption + relicFoodConsumption) < 0)
                {
                    foodStock = 0;
                    sailorsStock--;
                    if(sailorsStock == 0)
                    {
                        Defeat("Food");
                    }
                    else
                    {
                        print("You have to eat one of your men to survive.");
                    }
                    if (sailorsStock < 0)
                        Debug.LogError("You shoudln't be there.");
                }
                else
                {
                    foodStock -= (lvl1_foodConsumption + relicFoodConsumption);
                }
                break;
            case GameLevel.lvl2:
                if (lvl2_foodConsumption + relicFoodConsumption <= 0)
                    break;
                if (foodStock - (lvl2_foodConsumption + relicFoodConsumption) == 0)
                {
                    foodStock = 0;
                    print("You ate your last rations when you got here.");
                }
                else if (foodStock - (lvl2_foodConsumption + relicFoodConsumption) < 0)
                {
                    foodStock = 0;
                    sailorsStock--;
                    if (sailorsStock == 0)
                    {
                        Defeat("Food");
                    }
                    if (sailorsStock < 0)
                        Debug.LogError("You shoudnl't be there.");
                }
                else
                {
                    foodStock -= (lvl2_foodConsumption + relicFoodConsumption);
                }
                break;
            case GameLevel.lvl3:
                if (lvl3_foodConsumption + relicFoodConsumption <= 0)
                    break;
                if (foodStock - (lvl3_foodConsumption + relicFoodConsumption) == 0)
                {
                    foodStock = 0;
                    print("You have eaten your last rations to come up here.");
                }
                else if (foodStock - (lvl3_foodConsumption + relicFoodConsumption) < 0)
                {
                    foodStock = 0;
                    sailorsStock--;
                    if (sailorsStock == 0)
                    {
                        Defeat("Food");
                    }
                    if (sailorsStock < 0)
                        Debug.LogError("You shoudnl't be there.");
                }
                else
                {
                    foodStock -= (lvl3_foodConsumption + relicFoodConsumption);
                }
                break;
            default:
                Debug.LogError("You shoudln't be there.");
                break;
        }
        if ((woodStock - relicWoodConsumption == 0) && woodStock != 0)
        {
            woodStock = 0;
            print("You have used your last wood to come up here.");
        }
        else if (woodStock - relicWoodConsumption < 0)
        {
            woodStock = 0;
            Defeat("Wood");
        }
        else
            woodStock -= relicWoodConsumption;     
    }

    public void ShowRessources()
    {
        print("Ship supplies :");
        print("Sailor : " + GameManager.Instance.sailorsStock + "/" + GameManager.Instance.sailorsMaxStock + " | Food : " + GameManager.Instance.foodStock + "/" + GameManager.Instance.foodMaxStock
            + "  | Wood : " + GameManager.Instance.woodStock + "/" + GameManager.Instance.woodMaxStock +
            " | Gold : " + GameManager.Instance.goldStock + "/" + GameManager.Instance.goldMaxStock);
    }

    IEnumerator LoadNextEncounter()
    {
        alliesGift = false;
        monkeysPawTried = false;
        yield return new WaitForSeconds(3);
        encounterCounter++;
        print("----------------------------------------");
        if (famousExplorer)
        {
            famousExplorerCounter++;
            if (famousExplorerCounter == 3)
            {
                famousExplorerCounter = 0;
                if (sailorsStock < sailorsMaxStock)
                {
                    sailorsStock += famousExplorerReward;
                    print("A sailor has heard of your journey and wants to rejoin you. You gain a new sailor.");
                }
                else
                {
                    print("A sailor has heard of your journey and wants to rejoin you. But you don't have any place on your boat...");
                }
            }
        }
        randomEncounterScript.LoadRandomEncounter();
    }

    #region GETCOST
    public int GetSailorCost(Cost cost)
    {
        switch (currentLevel)
        {
            case GameLevel.lvl1:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return lvl1_lowSailorCost;
                    case Cost.medium:
                        return lvl1_mediumSailorCost;
                    case Cost.high:
                        return lvl1_highSailorCost;
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl2:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return lvl2_lowSailorCost;
                    case Cost.medium:
                        return lvl2_mediumSailorCost;
                    case Cost.high:
                        return lvl2_highSailorCost;
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl3:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return lvl3_lowSailorCost;
                    case Cost.medium:
                        return lvl3_mediumSailorCost;
                    case Cost.high:
                        return lvl3_highSailorCost;
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            default:
                Debug.LogError("Shouldn't be there.");
                return 0;
        }
    }
    public int GetFoodCost(Cost cost)
    {
        switch (currentLevel)
        {
            case GameLevel.lvl1:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return lvl1_lowFoodCost;
                    case Cost.medium:
                        return lvl1_mediumFoodCost;
                    case Cost.high:
                        return lvl1_highFoodCost;
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl2:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return lvl2_lowFoodCost;
                    case Cost.medium:
                        return lvl2_mediumFoodCost;
                    case Cost.high:
                        return lvl2_highFoodCost;
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl3:
                switch (cost)
                {
                    case Cost.none:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                    case Cost.low:
                        return lvl3_lowFoodCost;
                    case Cost.medium:
                        return lvl3_mediumFoodCost;
                    case Cost.high:
                        return lvl3_highFoodCost;
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            default:
                Debug.LogError("Shouldn't be there.");
                return 0;
        }
    }
    public int GetWoodCost(Cost cost)
    {
        switch (currentLevel)
        {
            case GameLevel.lvl1:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return lvl1_lowWoodCost;
                    case Cost.medium:
                        return lvl1_mediumWoodCost;
                    case Cost.high:
                        return lvl1_highWoodCost;
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl2:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return lvl2_lowWoodCost;
                    case Cost.medium:
                        return lvl2_mediumWoodCost;
                    case Cost.high:
                        return lvl2_highWoodCost;
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl3:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return lvl3_lowWoodCost;
                    case Cost.medium:
                        return lvl3_mediumWoodCost;
                    case Cost.high:
                        return lvl3_highWoodCost;
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            default:
                Debug.LogError("Shouldn't be there.");
                return 0;
        }
    }
    public int GetGoldCost(Cost cost)
    {
        switch (currentLevel)
        {
            case GameLevel.lvl1:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return lvl1_lowGoldCost;
                    case Cost.medium:
                        return lvl1_mediumGoldCost;
                    case Cost.high:
                        return lvl1_highGoldCost;
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl2:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return lvl2_lowGoldCost;
                    case Cost.medium:
                        return lvl2_mediumGoldCost;
                    case Cost.high:
                        return lvl2_highGoldCost;
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl3:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return lvl3_lowGoldCost;
                    case Cost.medium:
                        return lvl3_mediumGoldCost;
                    case Cost.high:
                        return lvl3_highGoldCost;
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            default:
                Debug.LogError("Shouldn't be there.");
                return 0;
        }
    }
    public int GetSailorReward(Cost cost)
    {
        switch (currentLevel)
        {
            case GameLevel.lvl1:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return Random.Range(lvl1_lowSailorMIN, lvl1_lowSailorMAX + 1);
                    case Cost.medium:
                        return Random.Range(lvl1_mediumSailorMIN, lvl1_mediumSailorMAX + 1);
                    case Cost.high:
                        return Random.Range(lvl1_highSailorMIN, lvl1_highSailorMAX + 1);
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl2:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return Random.Range(lvl2_lowSailorMIN, lvl2_lowSailorMAX + 1);
                    case Cost.medium:
                        return Random.Range(lvl2_mediumSailorMIN, lvl2_mediumSailorMAX + 1);
                    case Cost.high:
                        return Random.Range(lvl2_highSailorMIN, lvl2_highSailorMAX + 1);
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl3:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return Random.Range(lvl3_lowSailorMIN, lvl3_lowSailorMAX + 1);
                    case Cost.medium:
                        return Random.Range(lvl3_mediumSailorMIN, lvl3_mediumSailorMAX + 1);
                    case Cost.high:
                        return Random.Range(lvl3_highSailorMIN, lvl3_highSailorMAX + 1);
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            default:
                Debug.LogError("Shouldn't be there.");
                return 0;
        }
    }
    public int GetFoodReward(Cost cost)
    {
        switch (currentLevel)
        {
            case GameLevel.lvl1:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return Random.Range(lvl1_lowFoodMIN, lvl1_lowFoodMAX + 1);
                    case Cost.medium:
                        return Random.Range(lvl1_mediumFoodMIN, lvl1_mediumFoodMAX + 1);
                    case Cost.high:
                        return Random.Range(lvl1_highFoodMIN, lvl1_highFoodMAX + 1);
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl2:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return Random.Range(lvl2_lowFoodMIN, lvl2_lowFoodMAX + 1);
                    case Cost.medium:
                        return Random.Range(lvl2_mediumFoodMIN, lvl2_mediumFoodMAX + 1);
                    case Cost.high:
                        return Random.Range(lvl2_highFoodMIN, lvl2_highFoodMAX + 1);
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl3:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return Random.Range(lvl3_lowFoodMIN, lvl3_lowFoodMAX + 1);
                    case Cost.medium:
                        return Random.Range(lvl3_mediumFoodMIN, lvl3_mediumFoodMAX + 1);
                    case Cost.high:
                        return Random.Range(lvl3_highFoodMIN, lvl3_highFoodMAX + 1);
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            default:
                Debug.LogError("Shouldn't be there.");
                return 0;
        }
    }
    public int GetWoodReward(Cost cost)
    {
        switch (currentLevel)
        {
            case GameLevel.lvl1:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return Random.Range(lvl1_lowWoodMIN, lvl1_lowWoodMAX + 1);
                    case Cost.medium:
                        return Random.Range(lvl1_mediumWoodMIN, lvl1_mediumWoodMAX + 1);
                    case Cost.high:
                        return Random.Range(lvl1_highWoodMIN, lvl1_highWoodMAX + 1);
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl2:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return Random.Range(lvl2_lowWoodMIN, lvl2_lowWoodMAX + 1);
                    case Cost.medium:
                        return Random.Range(lvl2_mediumWoodMIN, lvl2_mediumWoodMAX + 1);
                    case Cost.high:
                        return Random.Range(lvl2_highWoodMIN, lvl2_highWoodMAX + 1);
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl3:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return Random.Range(lvl3_lowWoodMIN, lvl3_lowWoodMAX + 1);
                    case Cost.medium:
                        return Random.Range(lvl3_mediumWoodMIN, lvl3_mediumWoodMAX + 1);
                    case Cost.high:
                        return Random.Range(lvl3_highWoodMIN, lvl3_highWoodMAX + 1);
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            default:
                Debug.LogError("Shouldn't be there.");
                return 0;
        }
    }
    public int GetGoldReward(Cost cost)
    {
        switch (currentLevel)
        {
            case GameLevel.lvl1:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return Random.Range(lvl1_lowGoldMIN, lvl1_lowGoldMAX + 1);
                    case Cost.medium:
                        return Random.Range(lvl1_mediumGoldMIN, lvl1_mediumGoldMAX + 1);
                    case Cost.high:
                        return Random.Range(lvl1_highGoldMIN, lvl1_highGoldMAX + 1);
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl2:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return Random.Range(lvl2_lowGoldMIN, lvl2_lowGoldMAX + 1);
                    case Cost.medium:
                        return Random.Range(lvl2_mediumGoldMIN, lvl2_mediumGoldMAX + 1);
                    case Cost.high:
                        return Random.Range(lvl2_highGoldMIN, lvl2_highGoldMAX + 1);
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            case GameLevel.lvl3:
                switch (cost)
                {
                    case Cost.none:
                        return 0;
                    case Cost.low:
                        return Random.Range(lvl3_lowGoldMIN, lvl3_lowGoldMAX + 1);
                    case Cost.medium:
                        return Random.Range(lvl3_mediumGoldMIN, lvl3_mediumGoldMAX + 1);
                    case Cost.high:
                        return Random.Range(lvl3_highGoldMIN, lvl3_highGoldMAX + 1);
                    default:
                        Debug.LogError("Shouldn't be there.");
                        return 0;
                }
            default:
                Debug.LogError("Shouldn't be there.");
                return 0;
        }
    }

    public int GetGoldCostCarpenter(GameLevel cost)
    {
        switch (cost)
        {
            case GameLevel.lvl1:
                return lvl1_highGoldCost;
            case GameLevel.lvl2:
                return lvl2_highGoldCost;
            case GameLevel.lvl3:
                return lvl3_highGoldCost;
            default:
                print("You shouldn't be there.");
                return 0;
        }
    }
    #endregion

    #region RELICS
    void UnequipRelic(GameObject relic, bool relootable)
    {
        if (relic.GetComponent<Relic>().curse)
            cursesEquipped.Remove(relic);
        relicsEquipped.Remove(relic);
        if (relootable)
            relicsScript.AddLostRelic(relic);
        relic.GetComponent<Relic>().Unequip();
        print(relic.GetComponent<Relic>().name + " got removed.");
    }

    void UnequipRelic(string relicName, bool relootable)
    {
        GameObject relic = null;
        foreach (GameObject item in relicsEquipped)
        {
            if (item.GetComponent<Relic>().name == relicName)
            {
                relic = item;
                break;
            }
        }
        if (relic == null)
            Debug.LogError("There is no relic with this name : " + relicName);
        if (relic.GetComponent<Relic>().curse)
            cursesEquipped.Remove(relic);
        relicsEquipped.Remove(relic);
        if (relootable)
            relicsScript.AddLostRelic(relic);
        relic.GetComponent<Relic>().Unequip();
        print(relic.GetComponent<Relic>().name + " got removed.");
    }

    GameObject GetRelicReward(Cost cost, RelicType type, bool includeCurse)
    {
        if (relicsScript.ProbGetRelic(cost))
        {
            return relicsScript.GetRandomRelic(type, includeCurse);
        }
        else
            return null;
    }

    void LuckyClover()
    {
        if(Random.Range(0,2) == 1)
        {
            switch (Random.Range(0,4))
            {
                case 0:
                    if (sailorsStock + luckyCloverSailor <= sailorsMaxStock)
                        sailorsStock += luckyCloverSailor;
                    else
                        sailorsStock = sailorsMaxStock;
                    print("You have won " + luckyCloverSailor + " sailor thanks to your Lucky Clover (don't ask from where he came from).");
                    break;
                case 1:
                    if (foodStock + luckyCloverFood <= foodMaxStock)
                        foodStock += luckyCloverFood;
                    else
                        foodStock = foodMaxStock;
                    print("You have won " + luckyCloverFood + " food thanks to your Lucky Clover.");
                    break;
                case 2:
                    if (woodStock + luckyCloverWood <= woodMaxStock)
                        woodStock += luckyCloverWood;
                    else
                        woodStock = woodMaxStock;
                    print("You have won " + luckyCloverWood + " wood thanks to your Lucky Clover.");
                    break;
                case 3:
                    if (goldStock + luckyCloverGold <= goldMaxStock)
                        goldStock += luckyCloverGold;
                    else
                        goldStock = goldMaxStock;
                    print("You have won " + luckyCloverGold + " gold thanks to your Lucky Clover.");
                    break;
                default:
                    Debug.LogError("You shoudln't be there.");
                    break;
            }
        }
    }

    void MonkeysPaw()
    {
        monkeysPawTried = true;
        if(Random.Range(0,100) == 99)
        {
            GameObject relic = relicsScript.GetRandomRelic(RelicType.all, true);
            if (relic == null)
            {
                print("Sorry you should have won a " + (relic.GetComponent<Relic>().curse ? "relic (or a curse)" : "relic") + " with you monkey's paw but there are no more relics at all.");
            }
            else
            {
                Relic relicScript = relic.GetComponent<Relic>();
                relicsEquipped.Add(relic);
                if (relicScript.curse)
                    cursesEquipped.Add(relic);
                relicsScript.RemoveGainedRelic(relic);
                relicScript.Equip();
                print("You have a new " + (relicScript.curse ? "curse " : "relic ")+"thanks to your Monkey's Paw !");
                print(relicScript.name);
                print(relicScript.description);
                if (luckyClover)
                    LuckyClover();
            }
        }
    }

    public void Spyglass(int value)
    {
        shipsTableScript.Spyglass(value);
    }

    public void LoneTraveler(bool value)
    {
        shipsTableScript.LoneTraveler(value);
    }
    #endregion

    #region DEFEAT
    void CheckStock()
    {
        if (foodStock == 0)
        {
            print("You run out of food, care, next time you will have to eat one of your sailors.");
        }
        else if (foodStock < 0)
        {
            foodStock = 0;
            sailorsStock--;
            print("You kill one of your men to compensate for the lack of food, you monster.");
        }
        if (sailorsStock <= 0)
        {
            sailorsStock = 0;
            Defeat("Sailors");
        }
        if (woodStock == 0)
        {
            print("You run out of wood, next time you loose wood, your ship will sink.");
        }
        else if (woodStock < 0)
        {
            woodStock = 0;
            Defeat("Wood");
        }
        if (goldStock <= 0)
        {
            goldStock = 0;
        }
    }

    void Defeat(string cause)
    {
        switch (cause)
        {
            case "Food":
                print("You eat your last man to survive, do you deserve to be called captain ?");
                break;
            case "Wood":
                print("You have no more wood, you see your ship sink, shame on you.");
                break;
            case "Sailors":
                print("You lost all your men, you will die alone.");
                break;
            default:
                print("You loose.");
                break;
        }
    }
    #endregion

    #region ENUM
    public enum ResourceType
    {
        none, sailor, food, wood, gold
    }

    public enum Cost
    {
        none, low, medium, high
    }

    public enum GameLevel
    {
        lvl1, lvl2, lvl3
    }

    public enum BoatLevel
    {
        little, normal, big
    }

    public enum RelicType
    {
        none, all, merchant, carpenter, ship, ruin, kraken, villagerHelp,
    }
    #endregion

    #region STRUCT
    [System.Serializable]
    public struct Prob
    {
        public string ID;
        [Range(0, 100)] public int prob;

        public Prob(string newID, int newProb)
        {
            ID = newID;
            prob = newProb;
        }
    }

    [System.Serializable]
    public struct Action
    {
        public string name;
        public string ID;
        public string ID2;
        [Header("Price")]
        public GameManager.Cost sailorPrice;
        public GameManager.Cost foodPrice;
        public GameManager.Cost woodPrice;
        public GameManager.Cost goldPrice;
        [Header("Reward")]
        public GameManager.Cost sailorReward;
        public GameManager.Cost foodReward;
        public GameManager.Cost woodReward;
        public GameManager.Cost goldReward;
        public GameManager.Cost relicReward;
        [Header("Relic")]
        public GameManager.RelicType relicType;
        public bool includeCurse;
    }

    [System.Serializable]
    public struct ProbUpgrade
    {
        public string ID;
        [Range(0, 100)] public int prob;
        public GameLevel levelUpgrade;
    }
    #endregion
}
