using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popo : Pokemon
{
    private void Start()
    {
        name = "Popo";
        ID = 10;
        gender = Gender.None;
        type = Type.Psychic;
        hp = 5;
        lvl = 1;
        attack = 50;
    }
}