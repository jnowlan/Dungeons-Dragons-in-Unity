using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

    public int Str, Con, Cha, Dex, Wis, Int; 
    public int StrMod, ConMod, ChaMod, DexMod, WisMod, IntMod;
    public int Athletics, Acrobatics, Sleight_of_Hand, Stealth, Arcana, History, Investigation, Nature, Religion, Animal_Handling, Insight, Medicine, Perception, Survival, Deception, Intimidation, Performance, Persuasion;
    private int lvl;
    public int MaxHP, CurHp;
    public int AC, Initiative, Speed;

    // Use this for initialization
    void Start()
    {
        Str = 20;
        StrMod = ((Str - 10) / 2);
        Athletics = StrMod;

        Con = 12;
        ConMod = ((Con - 10) / 2);

        Cha = 6;
        ChaMod = ((Cha - 10) / 2);
        Deception = ChaMod;
        Intimidation = ChaMod;
        Performance = ChaMod;
        Persuasion = ChaMod;

        Dex = 14;
        DexMod = ((Dex - 10) / 2);
        Acrobatics = DexMod;
        Sleight_of_Hand = DexMod;
        Stealth = DexMod;

        Wis = 11;
        WisMod = ((Wis - 10) / 2);
        Animal_Handling = WisMod;
        Insight = WisMod;
        Medicine = WisMod;
        Perception = WisMod;
        Survival = WisMod;

        Int = 2;
        IntMod = ((Int - 10) / 2);
        Arcana = IntMod;
        History = IntMod;
        Investigation = IntMod;
        Nature = IntMod;
        Religion = IntMod;
 
    }


    // Update is called once per frame
    void Update()
    {

    }
}

