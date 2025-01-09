using UnityEngine;

public class EnemyTypeA : Enemy
{
    public override Color MaterialColor { get; protected set; } = Color.cyan;
    public override float Speed { get; protected set; } = 1f;
}
