using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlX : Pokemon
{
    private void Start()
    {
        name = "AltF4";
        ID = 09;
        gender = Gender.Male;
        type = Type.Psychic;
        hp = 10;
        lvl = 1;
        attack = 40;
    }
}
