using UnityEngine;
using System.Collections;

public class Pelota : MonoBehaviour {

    bool EnJuego;
    public Rigidbody RigidPelota;

	// Use this for initialization
	void Start () {
        //RigidPelota = GetComponent<Rigidbody>();
	}

    void Awake()
    {
        
    }
	// Update is called once per frame
	void Update () {
        //Debug.logger.Log(!EnJuego && Input.GetButtonDown("Fire1"));
        Debug.logger.Log("esta iniciado: "+ EnJuego);
        Debug.logger.Log("Fire : "+ Input.GetButtonDown("Fire1").ToString());
        if (!EnJuego && Input.GetButtonDown("Fire1"))
        {
            EnJuego = true;
            transform.SetParent(null);
            RigidPelota.isKinematic = false;
            RigidPelota.AddForce(new Vector3(10, 10));
            RigidPelota.velocity = new Vector3(20, 20);
        }
	}
}
