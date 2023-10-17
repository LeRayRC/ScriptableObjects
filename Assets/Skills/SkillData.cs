using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Item", menuName= "MyLoL/Create new Item", order= 101)]
public class SkillData : ScriptableObject
{
    // Start is called before the first frame update
    public GameObject skillPrefab;
    [SerializeField]
    public int spellID;

    public virtual void Use(SpellBook sp){
        
    }
}


