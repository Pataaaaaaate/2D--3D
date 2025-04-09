using UnityEngine;

public class GetKey : MonoBehaviour
{
    public bool hasKey = false;

    private void OnTriggerEnter(Collider other)
    {
        hasKey = true;
        Destroy(gameObject);
    }
}
