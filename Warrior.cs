using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour {

    Stats st = new Stats();

	// Use this for initialization
	void Start () {
        st.Str = 16;
        st.Con = 16;
        st.Int = 8;
        st.Cha = 10;
        st.Wis = 8;
        st.Dex = 15;
    }
	
	// Update is called once per frame
	void Update () {
      
    }
}
