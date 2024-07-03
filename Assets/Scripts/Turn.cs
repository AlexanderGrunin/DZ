using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private float _speedRotation = 30f;

    private void Update()
    {
        transform.Rotate(Vector3.up, _speedRotation * Time.deltaTime);
    }
}