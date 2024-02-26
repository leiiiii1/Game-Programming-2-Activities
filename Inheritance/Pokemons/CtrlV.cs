using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlV : Pokemon
{
    private void Start()
    {
        name = "CtrlV";
        ID = 08;
        gender = Gender.None;
        type = Type.Poison;
        hp = 20;
        lvl = 1;
        attack = 10;
    }
}
