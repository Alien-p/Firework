using UnityEngine;

public class GenerateFirework : MonoBehaviour {
    
    public GameObject firework;         //частица салюта

    //фнкция создания частиц салюта
    public void FireworkIns()
    {
        //в цикле создается 200 частиц салюта
        for (int i = 0; i < 200; i++)
        {
            Instantiate(firework, transform.position, transform.rotation);
        }
    }

}
