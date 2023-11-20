using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropRateList : MonoBehaviour
{
    [Header("Chest Types")]
    [SerializeField] int woodenChest = 450;
    [SerializeField] int bronzeChest = 250;
    [SerializeField] int silverChest = 100;
    [SerializeField] int goldChest = 20;
    [SerializeField] int platinumChest = 1;
    [SerializeField] List<string> chestTypes;

    [Header("Wooden Chest")]
    [SerializeField] int woodenChestCommon = 200;
    [SerializeField] int woodenChestUncommon = 60;
    [SerializeField] int woodenChestRare = 10;
    [SerializeField] int woodenChestEpic = 4;
    [SerializeField] int woodenChestLegendary = 1;
    [SerializeField] List<string> woodChestDrops;

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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
