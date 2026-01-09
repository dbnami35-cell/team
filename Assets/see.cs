using UnityEngine;
[ExecuteInEditMode]
public class see : MonoBehaviour
{
    void LateUpdate()
    {
        // 카메라를 똑바로 바라보게 만듭니다.
        transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward,
                         Camera.main.transform.rotation * Vector3.up);
    }
}