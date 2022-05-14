using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public int hp = 3;

    private void Update()
    {
        float hInput = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(hInput, 0) * Time.deltaTime * speed;
    }

    public void Hit()
    {
        hp--;
        if (hp < 1)
        {
            Debug.Log("게임 오버");
            Destroy(gameObject);
        }
    }
}