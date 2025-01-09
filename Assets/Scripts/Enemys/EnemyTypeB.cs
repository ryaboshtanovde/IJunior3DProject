using UnityEngine;

public class EnemyTypeB : Enemy
{
    public override Color MaterialColor { get; protected set; } = Color.magenta;
    public override float Speed { get; protected set; } = 1.5f;
}
