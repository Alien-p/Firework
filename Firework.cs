using UnityEngine;

public class Firework : MonoBehaviour {

    private Rigidbody rb;
    public float movementSpeed = 10f;                                       //скорость ракеты

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //делает ракету не активной
    public void Explode()
    {
        gameObject.SetActive(false);
    }

    //функция движения ракеты
    public void startMove()
    {
        float moveVertical = 100f;
        Vector3 move = new Vector3(0.0f, moveVertical, 0.0f);
        rb.AddForce(move * movementSpeed * Time.deltaTime);
    }
}
