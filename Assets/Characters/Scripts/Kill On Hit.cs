using UnityEngine;

public class Killonhit : MonoBehaviour
{
    public string targetTag;
    public GameObject effect;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            GameObject expl = Instantiate(effect);
            Destroy(expl, 2f);
            Destroy(coll.gameObject, 0.1f);
            audioSource.Play();

        }
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            GameObject expl = Instantiate(effect);
            Destroy(expl, 2f);
            Destroy(coll.gameObject, 0.1f);
            audioSource.Play();

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}

