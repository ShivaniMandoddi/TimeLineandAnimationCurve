using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    // Start is called before the first frame update
    public AnimationCurve animationCurve;
    Animation animations;
    public float curveTime=3f;
    public float playerSpeed=5f;
    public Vector3 currentPosition;

    void Start()
    {
        animations = GetComponent<Animation>();
        //animationCurve.Evaluate(curveTime);
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;
        currentPosition.z += playerSpeed * Time.deltaTime;
        
        curveTime = Mathf.PingPong(0f,1f);
        
        currentPosition.y = animationCurve.Evaluate(curveTime);
        Debug.Log(currentPosition.y);
        transform.position = currentPosition;
    }
}
