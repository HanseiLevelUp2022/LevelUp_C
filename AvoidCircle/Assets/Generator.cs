using UnityEngine;
using Random = UnityEngine.Random;

public class Generator : MonoBehaviour
{
    public Enemy prefab;

    private void Start() // 시작하면 호출
    {
        InvokeRepeating("Create", 1, 1);
    }

    private void Create()
    {
        var obj = Instantiate(prefab);
        obj.transform.position = transform.position;
        obj.transform.position += new Vector3(Random.Range(-7, 8), 0);
    }
}