using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public static TurnManager Instance;

    public bool playerTurn = true;

    private void Awake()
    {
        Instance = this;
    }

    public void EndPlayerTurn()
    {
        playerTurn = false;

        UIManager.Instance.UpdateTurnText("Enemy Turn");

        EnemyAI[] enemies = FindObjectsOfType<EnemyAI>();

        foreach (EnemyAI enemy in enemies)
        {
            enemy.TakeTurn();
        }

        playerTurn = true;

        UIManager.Instance.UpdateTurnText("Player Turn");
    }
}