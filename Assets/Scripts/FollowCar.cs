using UnityEngine;

public class FollowCar : MonoBehaviour
{
    [SerializeField]
    private float _mouseSensitivity = 3.0f;

    private float _rotationY;

    private float _rotationX;

    [SerializeField]
    private Transform _target;

    [SerializeField]
    private float _distancefromTarget = 3.0f;

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")* _mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y")* _mouseSensitivity;

        _rotationX += mouseX;
        _rotationY += mouseY;
        
        _rotationX = Mathf.Clamp(_rotationX,-30,30);
        _rotationY = Mathf.Clamp(_rotationY, -60,60);
        transform.localEulerAngles = new Vector3(_rotationY,_rotationX,0);

        transform.position = _target.position - transform.forward * _distancefromTarget;
    }
}
