using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad : Pokemon
{
    private void Start()
    {
        name = "Bad";
        ID = 03;
        gender = Gender.None;
        type = Type.Water;
        hp = 30;
        lvl = 1;
        attack = 23;
    }
}
