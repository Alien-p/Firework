using UnityEngine;

public class Sphere : MonoBehaviour {

    public float speed;                                             //скорость частиц салюта
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Move();
    }

    void Update()
    {
        Destroy(gameObject, 3f);                                    //разрушаем частицы салюта через 3 секунды
    }

    //функция задает случайное движение частиц салюта
    void Move()
    {
        float randomX = Random.Range(-300, 300);
        float randomY = Random.Range(-300, 300);
        float randomZ = Random.Range(-300, 300);
        Vector3 dir = new Vector3(randomX, randomY, randomZ);       //задаем направление движения частиц салюта
        rb.AddForce(dir * Time.deltaTime * speed);                  //задаем движение частиц салюта
    }

}
