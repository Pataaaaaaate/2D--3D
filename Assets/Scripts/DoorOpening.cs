using UnityEngine;

public class DoorOpening : MonoBehaviour
{

    [SerializeField] public GetKey key;

    private void Update()
    {
        if (key.hasKey)
        {
            Destroy(gameObject);
        }
    }

}
