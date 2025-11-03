using NUnit.Framework;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System;
using UnityEngine;

[Serializable]
public class EntityAttackDistribution {

    public EntityAttack attack { get; set; }
    public int weight { get; set; }

    public EntityAttackDistribution(EntityAttack attack, int weight) {
        this.attack = attack;
        this.weight = weight;
    }

}
