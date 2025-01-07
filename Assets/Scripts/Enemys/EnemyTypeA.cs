using UnityEngine;

public class EnemyTypeA : Enemy
{
    public override Color MaterialColor { get; set; } = Color.cyan;
    public override float Speed { get; set; } = 0.1f;
}
