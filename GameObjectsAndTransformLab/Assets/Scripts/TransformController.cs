using UnityEngine;

public class TansformController : MonoBehaviour
{
    private void Update()
    {
        //Moving the game object
        var x = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(0, x, 0);
        transform.position = p;

        // rotate the game object
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime * 10);
    }

}

