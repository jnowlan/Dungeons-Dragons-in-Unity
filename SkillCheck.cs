using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillCheck{

	public bool PassedCheck(int SkillMod, int MinPassingValue)
    {
        int rand = (Random.Range(1, 20));
        int SkillRoll = rand + SkillMod;

        Debug.Log("Dice Roll: " + rand + " + Skill Modifier: " + SkillMod + " = " + SkillRoll);

        if (SkillRoll >= MinPassingValue)
            return true;

        else
            return false;
    }
}
