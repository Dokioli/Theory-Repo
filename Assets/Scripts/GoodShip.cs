using TMPro;
using UnityEngine;

public class GoodShip : Player        // INHERITANCE
{
    [SerializeField] TextMeshProUGUI shipName;
    [SerializeField] string shipNamestring;
    public override void DisplayName() // POLYMORPHISM
    {
        shipName.text = "Name: "+shipNamestring;
    }
}
