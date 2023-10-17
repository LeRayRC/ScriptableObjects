using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBook : MonoBehaviour
{
    // Start is called before the first frame update
    public SkillData skill1_;
    public SkillData skill2_;

    public float currentHealth_;
    [SerializeField]
    public float maxHealth_;
    void Start()
    {
        maxHealth_ = currentHealth_;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Skill1")){
            Debug.Log("Pressing Skill1");
            skill1_.Use(this);
        }else if(Input.GetButtonDown("Skill2")){
            Debug.Log("Pressing Skill2");
            skill2_.Use(this);
        }
    }
}
