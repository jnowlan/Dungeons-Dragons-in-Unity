using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillEvent : MonoBehaviour {

    SkillCheck sc = new SkillCheck();
    GameObject player;

    int skillMod;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");   
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
      
        Debug.Log(sc.PassedCheck(skillMod, 10));
 
    }

    public void Athletics()
    {
        skillMod = player.GetComponent<Stats>().Athletics;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Acrobatics()
    {
        skillMod = player.GetComponent<Stats>().Acrobatics; 
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Sleight_of_Hand()
    {
        skillMod = player.GetComponent<Stats>().Sleight_of_Hand;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Stealth()
    {
        skillMod = player.GetComponent<Stats>().Stealth;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Arcana()
    {
        skillMod = player.GetComponent<Stats>().Arcana;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void History()
    {
        skillMod = player.GetComponent<Stats>().History;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Investigation()
    {
        skillMod = player.GetComponent<Stats>().Investigation;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Nature()
    {
        skillMod = player.GetComponent<Stats>().Nature;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Relgiion()
    {
        skillMod = player.GetComponent<Stats>().Religion;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Animal_Handling()
    {
        skillMod = player.GetComponent<Stats>().Animal_Handling;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Insight()
    {
        skillMod = player.GetComponent<Stats>().Insight;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Medicine()
    {
        skillMod = player.GetComponent<Stats>().Medicine;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Perception()
    {
        skillMod = player.GetComponent<Stats>().Perception;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Survival()
    {
        skillMod = player.GetComponent<Stats>().Survival;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Deception()
    {
        skillMod = player.GetComponent<Stats>().Deception;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Intimidation()
    {
        skillMod = player.GetComponent<Stats>().Intimidation;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Performance()
    {
        skillMod = player.GetComponent<Stats>().Performance;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

    public void Persuasion()
    {
        skillMod = player.GetComponent<Stats>().Persuasion;
        Debug.Log(sc.PassedCheck(skillMod, 10));
    }

}
