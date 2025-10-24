using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEntity : MonoBehaviour {

    private float attackPower;
    private float moveSpeed;
    private float hitPoints;

    List<EntityAttack> entityAttacks;
    List<EntityAttackDistribution> attackDistribution;

    // Deliberately kept empty at the moment per Sujan - (10/21/25 | Snype)
    void Patrol() {
    }

    void AddDistribution(EntityAttack attack_, int weight_) {
        /* Checking to see if an attack already exists in the moveset (?) and adding the entry's
             * weight_ to the existing weight, to indicate that the entity should have a
             * higher percentage of doing a certain attack (?) - (10/21/25 | Snype)
             */

        for (int i = 0; i < attackDistribution.Count; i++) {
            if (attack_ == attackDistribution[i].attack) {
                attackDistribution[i].weight = weight_;
                return;
            }
        }
        attackDistribution.Add(new EntityAttackDistribution(attack_, weight_));
        
    }
}