using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerStats : MonoBehaviour
{
    public TowerBase tower;

    public CapsuleCollider towerRange;
    private float damage;
    private float attackSpeed;

    void Start()
    {
        Set_Tower_Range();
        Set_Tower_Damage();
        Set_Tower_AttackSpeed();
    }

    void Set_Tower_Range()
    {
        towerRange.radius = tower.range;
    }

    void Set_Tower_Damage()
    {
        damage = tower.damage;
    }

    void Set_Tower_AttackSpeed()
    {
        attackSpeed = tower.attackSpeed;
    }
}
