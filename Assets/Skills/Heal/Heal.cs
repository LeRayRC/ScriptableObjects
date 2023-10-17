using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Heal", menuName= "MyLoL/Spell/Heal", order= 101)]
public class Heal : SkillData{
    public float healing_amount_;
    public float rotateSpeed_;
    public float forceCast_;

    public override void Use(SpellBook sp) {
        sp.currentHealth_ += healing_amount_;
        if(sp.currentHealth_ >= sp.maxHealth_){
            sp.currentHealth_ = sp.maxHealth_;
        }

        Debug.Log("Healing");
        GameObject go_ = GameObject.Instantiate<GameObject>(skillPrefab,new Vector3(sp.transform.position.x + 5.0f, sp.transform.position.y, sp.transform.position.z + sp.transform.forward.z * 8.0f),sp.transform.rotation);
        Rigidbody rb_ = go_.GetComponent<Rigidbody>();
        rb_.AddForce(forceCast_ * sp.transform.up, ForceMode.Impulse);
        Destroy(go_,2.0f);
    }
}
