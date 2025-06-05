using UnityEngine;

public class GoodShip : Player        // INHERITANCE
{
    public override void DisplayName()
    {
        Debug.Log(gameObject.name);
    }
}
