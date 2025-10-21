using NUnit.Framework;
using UnityEngine;

public class EntityAttackDistribution : MonoBehaviour {

    public EntityAttack attack { get; set; }
    public int weight { get; set; }

    public EntityAttackDistribution(EntityAttack attack, int weight) {
        this.attack = attack;
        this.weight = weight;
    }

}
