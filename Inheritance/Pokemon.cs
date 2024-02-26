using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    [Header("strings")]
    public string name;

    [Header("integer")]
    public int ID;

    [Header("Enums")]
    public Gender gender;
    public Type type;

    [Header("Stats")]
    public int hp;
    public int lvl;
    public int attack;

}
