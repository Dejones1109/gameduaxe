using System.Collections;

using UnityEngine;

public class PlayCallback : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(Input.GetAxis("Mouse X"), 0, 0.5f);
        Camera.main.transform.position += new Vector3(0, 0, 0.5f);         
    }
}
