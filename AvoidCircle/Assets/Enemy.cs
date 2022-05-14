using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10;

    private void Update()
    {
        transform.position += new Vector3(0, -1, 0) * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Floor"))
        {
            Debug.Log("바닥에 닿음");
            Destroy(gameObject);
        }
        else if (col.CompareTag("Player"))
        {
            Debug.Log("플레이어에게 닿음");
            col.GetComponent<Player>().Hit();
            Destroy(gameObject);
        }
    }
}