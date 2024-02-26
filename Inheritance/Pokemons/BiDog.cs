using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiDog : Pokemon
{
    private void Start()
    {
        name = "BiDog";
        ID = 04;
        gender = Gender.Female;
        type = Type.Fire;
        hp = 30;
        lvl = 1;
        attack = 20;
    }
}
