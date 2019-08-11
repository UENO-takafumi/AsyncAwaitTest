using UnityEngine;

public class LightMove : MonoBehaviour
{
    void Update()
    {
        var angle = this.transform.localEulerAngles;
        this.transform.localEulerAngles = new Vector3(angle.x, angle.y + 10 * Time.deltaTime, angle.z);
    }
}
