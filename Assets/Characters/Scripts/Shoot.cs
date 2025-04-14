using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Public variabele voor de bullet prefab
    public GameObject prefab;

    void Update()
    {
        // Controleer of de Left Control-toets is ingedrukt
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Bullet schieten
            GameObject ob = Instantiate(prefab);
            ob.transform.position = transform.position;
            ob.transform.rotation = transform.rotation;
            Destroy(ob, 3f);
        }
    }

}
