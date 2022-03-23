using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string UnitName;
    public int UnitLevel;

    public int Damage;

    public int MaxHP;
    public int CurrentHP;

    public int Defence;

    public int FireResistance;
    public int IceResistance;
    public int WaterResistance;
    public int ElectricResistance;

    public bool TakeDamage(int damage) {
        CurrentHP -= damage;

        return CurrentHP <= 0;
    }
}
