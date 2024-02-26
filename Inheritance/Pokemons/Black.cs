using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black : Pokemon
{
    private void Start()
    {
        name = "Black";
        ID = 05;
        gender = Gender.Male;
        type = Type.Psychic;
        hp = 40;
        lvl = 1;
        attack = 7;
    }
}
