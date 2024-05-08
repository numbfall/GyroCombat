using System;
using UnityEngine;

[Serializable]
public class Bullet2 : MonoBehaviour
{
	public float destroyTime;

	public float destroyInterval;

	public int bulletSpeed;

	public Alive manager;

	public GameObject Splash;

	public GameObject Explosion;

	public Bullet2()
	{
		destroyInterval = 10f;
		bulletSpeed = 50;
	}

	public virtual void Start()
	{
		destroyTime = Time.time + destroyInterval;
		manager = (Alive)GameObject.FindWithTag("Manager").GetComponent(typeof(Alive));
	}

	public virtual void Update()
	{
		transform.position += transform.right * bulletSpeed * Time.deltaTime;
		SelfDestruct();
	}

	public virtual void SelfDestruct()
	{
		if (!(destroyTime >= Time.time))
		{
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public virtual void MovePixels()
	{
	}

	public virtual void OnTriggerEnter(Collider hit)
	{
		if (hit.gameObject.tag == "Player1")
		{
			UnityEngine.Object.Instantiate(Splash, gameObject.transform.position, Quaternion.identity);
			UnityEngine.Object.Destroy(gameObject);
			UnityEngine.Object.Instantiate(Explosion, transform.position, Quaternion.identity);
			UnityEngine.Object.Destroy(hit.gameObject);
			manager.PAlive = false;
		}
		else if (hit.gameObject.tag == "Wall" || hit.gameObject.tag == "Base")
		{
			UnityEngine.Object.Instantiate(Splash, gameObject.transform.position, Quaternion.identity);
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
