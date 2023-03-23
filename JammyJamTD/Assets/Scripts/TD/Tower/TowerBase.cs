using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tower", menuName = "Tower")]
public class TowerBase : ScriptableObject
{
    public new string name;
    public float damage;
    public float attackSpeed;
    public float range;
    public float cost;
    public Mesh mesh;
}
