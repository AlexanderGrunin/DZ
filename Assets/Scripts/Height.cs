using UnityEngine;

public class CapsuleHeight : MonoBehaviour
{
    [SerializeField] private float _speedHeight = 0.5f;

    private void Update()
    {
        transform.localScale += Vector3.one * _speedHeight * Time.deltaTime;
    }
}