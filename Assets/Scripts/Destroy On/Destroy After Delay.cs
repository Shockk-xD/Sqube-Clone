using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour
{
    [SerializeField] private float _delay;

    private void Start() {
        Destroy(gameObject, _delay);
    }
}
