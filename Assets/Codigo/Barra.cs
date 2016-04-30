using UnityEngine;
using System.Collections;

public class Barra : MonoBehaviour
{
    public float Velocidad = 0.4f;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update ()
	{
        //-1 , 0 , 1 
	    float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
	    float posX = transform.position.x + (tecladoHorizontal * Velocidad * Time.deltaTime);

        transform.position = new Vector3(Mathf.Clamp(posX, -8, 8), transform.position.y); 
	}
}
