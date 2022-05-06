using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    // Start is called before the first frame update
    public AnimationCurve animationCurve;
    /* Animation animations;
    // public float curveTime=3f;
     //public float playerSpeed=5f;
     public Vector3 currentPosition;*/
    public float playerSpeed = 5f;
    Transform currentTransform;
    void Start()
    {
        //animations = GetComponent<Animation>();
        //animationCurve.Evaluate(curveTime);
        currentTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        /* currentPosition = transform.position;
         currentPosition.z += playerSpeed * Time.deltaTime;

         curveTime = Mathf.PingPong(0f,1f);

         currentPosition.y = animationCurve.Evaluate(curveTime);
         Debug.Log(currentPosition.y);
         transform.position = currentPosition;
        */
        
        currentTransform.position += playerSpeed * currentTransform.forward*Time.deltaTime;
        float valueY=animationCurve.Evaluate(Mathf.PingPong(Time.time,1f));
        currentTransform.position = new Vector3(currentTransform.position.x, valueY, currentTransform.position.z);
    }
}
//Character Track
//Particle Track
//CineMachine Track
// Audio Track
