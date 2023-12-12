using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public StatToChange statToChange = new StatToChange();
    public int amountToChangeStat;
    public AttributeToChange attributeToChange = new AttributeToChange();
    public int amountToChangeAttribute;

    public bool UseItem()
    {
        if (statToChange == StatToChange.health)
        {
            HealthPlayer health = GameObject.Find("player").GetComponent<HealthPlayer>();
            if (health.currentHealth == health.maxhealth)
            {
                return false;
            }
            else
            {
                health.ChangeHealth(amountToChangeStat);
                return true;
            }
            health.ChangeHealth(amountToChangeStat);
        }
        return false;

    }

    public enum StatToChange
    {
        none,
        health,
        shield,
        damage,
        stamina
    };

    public enum AttributeToChange
    {
        none,
        speed,
        strenght,
        agility

    };
}
