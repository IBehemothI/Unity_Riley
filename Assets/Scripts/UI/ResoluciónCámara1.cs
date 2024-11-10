using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResoluciónCámara1 : MonoBehaviour
{
    public bool MantenerWidth = true;
    float DefaultWidth;
    float DefaultHeight;
    Vector3 PosCamara;
    [Range(-1, 1)]
    public int AdapPos;
    // Start is called before the first frame update
    void Start()
    {
        PosCamara = Camera.main.transform.position;
        DefaultHeight = Camera.main.orthographicSize;
        DefaultWidth = Camera.main.orthographicSize * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        if (MantenerWidth)
        {
            Camera.main.orthographicSize = DefaultWidth / Camera.main.aspect;
            Camera.main.transform.position = new Vector3(PosCamara.x, 1 * (DefaultHeight - Camera.main.orthographicSize), PosCamara.z);
        }
        else
        {
            Camera.main.transform.position = new Vector3(AdapPos * (DefaultWidth - Camera.main.orthographicSize), PosCamara.y, PosCamara.z);
        }
    }
}