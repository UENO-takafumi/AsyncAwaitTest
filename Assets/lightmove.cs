using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var angle = this.transform.localEulerAngles;
        this.transform.localEulerAngles = new Vector3(angle.x, angle.y + 10 * Time.deltaTime, angle.z);
    }
}
