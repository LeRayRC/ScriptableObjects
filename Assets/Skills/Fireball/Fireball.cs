using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Fireball", menuName = "MyLoL/Spell/Fireball", order = 101)]
public class Fireball : SkillData
{
    // Start is called before the first frame update
    public float selfDamage_;
    public float forceCast_;

    public override void Use(SpellBook sp)
    {
        if(sp.currentHealth_ / sp.maxHealth_ >= 0.5f ){
            sp.currentHealth_ -= selfDamage_;
        }
        Debug.Log("Launching Fireball!");
                GameObject go_ = GameObject.Instantiate<GameObject>(skillPrefab,new Vector3(sp.transform.position.x - 5.0f, sp.transform.position.y, sp.transform.position.z + sp.transform.forward.z * 8.0f),sp.transform.rotation);

        Rigidbody rb_ = go_.GetComponent<Rigidbody>();
        rb_.AddForce(forceCast_ * sp.transform.forward, ForceMode.Impulse);
        Destroy(go_,2.0f);
    }
}
