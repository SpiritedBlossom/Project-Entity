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

    public abstract void Patrol();

    void AddDistribution(EntityAttack attack_, int weight_) {
       

        for (int i = 0; i < attackDistribution.Count; i++) {
            if (attack_ == attackDistribution[i].attack) {
                attackDistribution[i].weight += weight_;
                return;
            }
        }
        attackDistribution.Add(new EntityAttackDistribution(attack_, weight_));
        
    }
}