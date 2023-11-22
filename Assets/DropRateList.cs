using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropRateList : MonoBehaviour
{
    //Use space to get a random chest and drop

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
     public int bronzeChestCommon = 100;
     public int bronzeChestUncommon = 100;
     public int bronzeChestRare = 50;
     public int bronzeChestEpic = 15;
     public int bronzeChestLegendary = 10;
     [SerializeField] List<string> bronzeChestDrops;
   
    [Header("Silver Chest")]
     public int silverChestCommon = 50;
     public int silverChestUncommon = 100;
     public int silverChestRare = 75;
     public int silverChestEpic = 35;
     public int silverChestLegendary = 15;
    [SerializeField] List<string> silverChestDrops;
   
    [Header("Gold Chest")]
     public int goldChestCommon = 0;
     public int goldChestUncommon = 75;
     public int goldChestRare = 125;
     public int goldChestEpic = 50;
     public int goldChestLegendary = 25;
    [SerializeField] List<string> goldChestDrops;
  
    [Header("Platinum Chest")]
     public int platinumChestCommon = 0;
     public int platinumChestUncommon = 0;
     public int platinumChestRare = 125;
     public int platinumChestEpic = 100;
     public int platinumChestLegendary = 50;
     [SerializeField] List<string> platinumChestDrops;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= woodenChest; i++)
        {
            chestTypes.Add("Wooden");
        }
        for (int i = 0; i <= bronzeChest; i++)
        {
            chestTypes.Add("Bronze");
        }
        for (int i = 0; i <= silverChest; i++)
        {
            chestTypes.Add("Silver");
        }
        for (int i = 0; i <= goldChest; i++)
        {
            chestTypes.Add("Gold");
        }
        for (int i = 0; i <= platinumChest; i++)
        {
            chestTypes.Add("Platinum");
        }


        for (int i = 0; i <= woodenChestCommon; i++)
        {
        woodChestDrops.Add("Common");
        }
        for (int i = 0; i <= woodenChestUncommon; i++)
        {
        woodChestDrops.Add("Uncommon");
        }
        for (int i = 0; i <= woodenChestRare; i++)
        {
        woodChestDrops.Add("Rare");
        }
        for (int i = 0; i <= woodenChestEpic; i++)
        {
        woodChestDrops.Add("Epic");
        }
        for (int i = 0; i <= woodenChestLegendary; i++)
        {
        woodChestDrops.Add("Legendary");
        }

        for (int i = 0; i <= bronzeChestCommon; i++)
        {
        bronzeChestDrops.Add("Common");
        }
        for (int i = 0; i <= bronzeChestUncommon; i++)
        {
        bronzeChestDrops.Add("Uncommon");
        }
        for (int i = 0; i <= bronzeChestRare; i++)
        {
        bronzeChestDrops.Add("Rare");
        }
        for (int i = 0; i <= bronzeChestEpic; i++)
        {
        bronzeChestDrops.Add("Epic");
        }
        for (int i = 0; i <= bronzeChestLegendary; i++)
        {
        bronzeChestDrops.Add("Legendary");
        }

        for (int i = 0; i <= silverChestCommon; i++)
        {
        silverChestDrops.Add("Common");
        }
        for (int i = 0; i <= silverChestUncommon; i++)
        {
        silverChestDrops.Add("Uncommon");
        }
        for (int i = 0; i <= silverChestRare; i++)
        {
        silverChestDrops.Add("Rare");
        }
        for (int i = 0; i <= silverChestEpic; i++)
        {
        silverChestDrops.Add("Epic");
        }
        for (int i = 0; i <= silverChestLegendary; i++)
        {
        silverChestDrops.Add("Legendary");
        }

        for (int i = 0; i <= goldChestCommon; i++)
        {
        goldChestDrops.Add("Common");
        }
        for (int i = 0; i <= goldChestUncommon; i++)
        {
        goldChestDrops.Add("Uncommon");
        }
        for (int i = 0; i <= goldChestRare; i++)
        {
        goldChestDrops.Add("Rare");
        }
        for (int i = 0; i <= goldChestEpic; i++)
        {
        goldChestDrops.Add("Epic");
        }
        for (int i = 0; i <= goldChestLegendary; i++)
        {
        goldChestDrops.Add("Legendary");
        }

        for (int i = 0; i <= platinumChestCommon; i++)
        {
        platinumChestDrops.Add("Common");
        }
        for (int i = 0; i <= platinumChestUncommon; i++)
        {
        platinumChestDrops.Add("Uncommon");
        }
        for (int i = 0; i <= platinumChestRare; i++)
        {
        platinumChestDrops.Add("Rare");
        }
        for (int i = 0; i <= platinumChestEpic; i++)
        {
        platinumChestDrops.Add("Epic");
        }
        for (int i = 0; i <= platinumChestLegendary; i++)
        {
        platinumChestDrops.Add("Legendary");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            System.Random rnd = new System.Random();
            int chestPicked = rnd.Next(chestTypes.Count);
            if (chestTypes[chestPicked] == "Wooden")
            {
                int woodPicked = rnd.Next(woodChestDrops.Count);
                Debug.Log((string)chestTypes[chestPicked] + woodChestDrops[woodPicked]);
            }
            if (chestTypes[chestPicked] == "Bronze")
            {
                int bronzePicked = rnd.Next(bronzeChestDrops.Count);
                Debug.Log((string)chestTypes[chestPicked] + bronzeChestDrops[bronzePicked]);
            }
            if (chestTypes[chestPicked] == "Silver")
            {
                int silverPicked = rnd.Next(silverChestDrops.Count);
                Debug.Log((string)chestTypes[chestPicked] + silverChestDrops[silverPicked]);
            }
            if (chestTypes[chestPicked] == "Gold")
            {
                int goldPicked = rnd.Next(goldChestDrops.Count);
                Debug.Log((string)chestTypes[chestPicked] + goldChestDrops[goldPicked]);
            }
            if (chestTypes[chestPicked] == "Platinum")
            {
                int platinumPicked = rnd.Next(platinumChestDrops.Count);
                Debug.Log((string)chestTypes[chestPicked] + platinumChestDrops[platinumPicked]);
            }
        }
    }
}
