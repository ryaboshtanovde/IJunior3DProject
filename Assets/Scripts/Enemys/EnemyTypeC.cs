using UnityEngine;

public class EnemyTypeC : Enemy
{
    public override Color MaterialColor { get; protected set; } = Color.green;
    public override float Speed { get; protected set; } = 0.5f;
}
