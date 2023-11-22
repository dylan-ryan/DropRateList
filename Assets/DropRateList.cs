using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropRateList : MonoBehaviour
{
    [Header("Chest Types")]
    public int woodenChest = 500;
    public int bronzeChest = 250;
    public int silverChest = 100;
    public int goldChest = 50;
    public int platinumChest = 15;
    [SerializeField] List<string> chestTypes;

    [Header("Wooden Chest")]
    public int woodenChestCommon = 200;
    public int woodenChestUncommon = 60;
    public int woodenChestRare = 10;
     public int woodenChestEpic = 4;
     public int woodenChestLegendary = 1;
    [SerializeField] List<string> woodChestDrops;
    
    [Header("Bronze Chest")]
    public int bronzeChestCommon = 200;
     public int bronzeChestUncommon = 60;
     public int bronzeChestRare = 10;
     public int bronzeChestEpic = 4;
     public int bronzeChestLegendary = 1;
     [SerializeField] List<string> bronzeChestDrops;
   
    [Header("Silver Chest")]
    public int silverChestCommon = 200;
    public int silverChestUncommon = 60;
    public int silverChestRare = 10;
    public int silverChestEpic = 4;
    public int silverChestLegendary = 1;
    [SerializeField] List<string> silverChestDrops;
   
    [Header("Gold Chest")]
    public int goldChestCommon = 200;
    public int goldChestUncommon = 60;
    public int goldChestRare = 10;
    public int goldChestEpic = 4;
    public int goldChestLegendary = 1;
    [SerializeField] List<string> goldChestDrops;
  
    [Header("Platinum Chest")]
    public int platinumChestCommon = 200;
    public int platinumChestUncommon = 60;
    public int platinumChestRare = 10;
    public int platinumChestEpic = 4;
    public int platinumChestLegendary = 1;
     [SerializeField] List<string> platinumChestDrops;

    // Start is called before the first frame update
    void Start()
    {
        chestTypes.Add("Wooden");
        chestTypes.Add("Bronze");
        chestTypes.Add("Silver");
        chestTypes.Add("Gold");
        chestTypes.Add("Platinum");

        woodChestDrops.Add("Common");
        woodChestDrops.Add("Uncommon");
        woodChestDrops.Add("Rare");
        woodChestDrops.Add("Epic");
        woodChestDrops.Add("Legendary");

        bronzeChestDrops.Add("Common");
        bronzeChestDrops.Add("Uncommon");
        bronzeChestDrops.Add("Rare");
        bronzeChestDrops.Add("Epic");
        bronzeChestDrops.Add("Legendary");

        silverChestDrops.Add("Common");
        silverChestDrops.Add("Uncommon");
        silverChestDrops.Add("Rare");
        silverChestDrops.Add("Epic");
        silverChestDrops.Add("Legendary");

        goldChestDrops.Add("Common");
        goldChestDrops.Add("Uncommon");
        goldChestDrops.Add("Rare");
        goldChestDrops.Add("Epic");
        goldChestDrops.Add("Legendary");

        platinumChestDrops.Add("Common");
        platinumChestDrops.Add("Uncommon");
        platinumChestDrops.Add("Rare");
        platinumChestDrops.Add("Epic");
        platinumChestDrops.Add("Legendary");

    }

    // Update is called once per frame
    void Update()
    {
        int chestsAddedUp = woodenChest + bronzeChest + silverChest + goldChest + platinumChest;
        int chestChance = UnityEngine.Random.Range (0, chestsAddedUp);
        //float woodenPercent = (woodenChest / chestsAddedUp) * 100f;
        //float bronzePercent = (bronzeChest / chestsAddedUp) * 100f;
        //float silverPercent = (silverChest / chestsAddedUp) * 100f;
        //float platinumPercent = (platinumChest / chestsAddedUp) * 100f;
        //Debug.Log("w"+woodenPercent+"b"+bronzePercent+"s"+silverPercent+"p"+platinumPercent);
    }
}
