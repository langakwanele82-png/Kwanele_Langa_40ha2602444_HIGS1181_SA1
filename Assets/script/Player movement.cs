public class PlayerController : MonoBehaviour
{
    public float tileSize = 1f;

    private bool canMove = true;

    void Update()
    {
        if (!canMove) return;

        Vector2 direction = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.W))
            direction = Vector2.up;

        else if (Input.GetKeyDown(KeyCode.S))
            direction = Vector2.down;

        else if (Input.GetKeyDown(KeyCode.A))
            direction = Vector2.left;

        else if (Input.GetKeyDown(KeyCode.D))
            direction = Vector2.right;

        if (direction != Vector2.zero)
        {
            Move(direction);
        }
    }

    void Move(Vector2 direction)
    {
        transform.position += (Vector3)(direction * tileSize);

        Debug.Log("Player Moved");

        TurnManager.Instance.EndPlayerTurn();
    }
}