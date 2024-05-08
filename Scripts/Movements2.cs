using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Movements2 : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024OnCollisionStay_0024120 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Collision _0024landed_0024121;

			internal Movements2 _0024self__0024122;

			public _0024(Collision landed, Movements2 self_)
			{
				_0024landed_0024121 = landed;
				_0024self__0024122 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024landed_0024121.gameObject.tag == "Base" && !(_0024self__0024122.Clipping.width >= 35.8f))
					{
						_0024self__0024122.Clipping.width = _0024self__0024122.Clipping.width + 0.1f;
					}
					if (_0024self__0024122.Clipping.width == 0f)
					{
						result = (Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
						break;
					}
					goto IL_00e8;
				case 2:
					UnityEngine.Object.Instantiate(_0024self__0024122.Explosion, _0024self__0024122.transform.position, Quaternion.identity);
					UnityEngine.Object.Destroy(_0024self__0024122.gameObject);
					_0024self__0024122.manager.EAlive = false;
					goto IL_00e8;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00e8:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Collision _0024landed_0024123;

		internal Movements2 _0024self__0024124;

		public _0024OnCollisionStay_0024120(Collision landed, Movements2 self_)
		{
			_0024landed_0024123 = landed;
			_0024self__0024124 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024landed_0024123, _0024self__0024124);
		}
	}

	public GameObject Bullet;

	private int Direction;

	public Vector3 relativeVelocity;

	public float fireRate;

	public float Lift;

	public int Pull;

	private float nextFire;

	public Alive manager;

	public float fuel;

	public int sheer;

	public int teer;

	public GameObject Explosion;

	public exClipping Clipping;

	public charSelection selected;

	public exSpriteAnimation spAnim;

	public string AnimeName;

	public string AttackAnime;

	public int selected2;

	public int hitsPer;

	public Movements2()
	{
		fireRate = 0.3f;
		Lift = 2.2f;
		Pull = 2;
		fuel = 100f;
		sheer = 1;
		teer = 3;
		hitsPer = 4;
	}

	public virtual void Start()
	{
		selected = (charSelection)GameObject.FindWithTag("Manager").GetComponent(typeof(charSelection));
		manager = (Alive)GameObject.FindWithTag("Manager").GetComponent(typeof(Alive));
		Clipping = (exClipping)GameObject.Find("clipping2").GetComponent(typeof(exClipping));
		Clipping.width = 35.8f;
		spAnim = (exSpriteAnimation)GetComponent(typeof(exSpriteAnimation));
		selected2 = PlayerPrefs.GetInt("Player2", 1);
		if (selected2 == 1)
		{
			AnimeName = "helimanAnime";
			AttackAnime = "HeliAttack";
		}
		if (selected2 == 2)
		{
			AnimeName = "flyDog";
			AttackAnime = "DogAttack";
		}
		if (selected2 == 3)
		{
			AnimeName = "Rocketflying";
			AttackAnime = "rocketAttack";
		}
	}

	public virtual void FixedUpdate()
	{
		float y = rigidbody.velocity.y - Mathf.Lerp(0f, Pull, 0.5f);
		Vector3 velocity = rigidbody.velocity;
		float num = (velocity.y = y);
		Vector3 vector2 = (rigidbody.velocity = velocity);
		if (Input.GetKey(KeyCode.I) && Clipping.width != 0f)
		{
			float y2 = rigidbody.velocity.y + Mathf.Lerp(Pull, Lift, 0.5f);
			Vector3 velocity2 = rigidbody.velocity;
			float num2 = (velocity2.y = y2);
			Vector3 vector4 = (rigidbody.velocity = velocity2);
			if (!(Clipping.width <= 0f))
			{
				Clipping.width -= 0.05f;
			}
		}
		if (Input.GetKeyDown(KeyCode.I))
		{
			spAnim.Play(AnimeName);
		}
		if (Input.GetKeyUp(KeyCode.I))
		{
			spAnim.Stop();
		}
		if (Input.GetKey(KeyCode.J))
		{
			if (!(transform.localScale.x >= 0f))
			{
				float x = transform.localScale.x * -1f;
				Vector3 localScale = transform.localScale;
				float num3 = (localScale.x = x);
				Vector3 vector6 = (transform.localScale = localScale);
			}
			Direction = 0;
			float x2 = rigidbody.velocity.x - Mathf.Lerp(sheer, teer, 0.2f);
			Vector3 velocity3 = rigidbody.velocity;
			float num4 = (velocity3.x = x2);
			Vector3 vector8 = (rigidbody.velocity = velocity3);
			if (!(Clipping.width <= 0f))
			{
				Clipping.width -= 0.01f;
			}
		}
		if (Input.GetKeyUp(KeyCode.J))
		{
		}
		if (Input.GetKey(KeyCode.L))
		{
			if (!(transform.localScale.x <= 0f))
			{
				float x3 = transform.localScale.x * -1f;
				Vector3 localScale2 = transform.localScale;
				float num5 = (localScale2.x = x3);
				Vector3 vector10 = (transform.localScale = localScale2);
			}
			Direction = 1;
			float x4 = rigidbody.velocity.x + Mathf.Lerp(sheer, teer, 0.2f);
			Vector3 velocity4 = rigidbody.velocity;
			float num6 = (velocity4.x = x4);
			Vector3 vector12 = (rigidbody.velocity = velocity4);
			if (!(Clipping.width <= 0f))
			{
				Clipping.width -= 0.01f;
			}
		}
		if (!Input.GetKeyUp(KeyCode.L))
		{
		}
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.U) && !(Time.time <= nextFire) && GameObject.FindGameObjectsWithTag("Bullet2").Length < hitsPer)
		{
			nextFire = Time.time + fireRate;
			if (Direction == 0)
			{
				spAnim.Play(AttackAnime);
				UnityEngine.Object.Instantiate(Bullet, transform.position, new Quaternion(0f, 180f, 0f, 0f));
			}
			else if (Direction == 1)
			{
				spAnim.Play(AttackAnime);
				UnityEngine.Object.Instantiate(Bullet, transform.position, Quaternion.identity);
			}
		}
	}

	public virtual void OnCollisionEnter(Collision collision)
	{
		if (!(collision.relativeVelocity.magnitude <= 130f))
		{
			UnityEngine.Object.Instantiate(Explosion, transform.position, Quaternion.identity);
			UnityEngine.Object.Destroy(gameObject);
			manager.EAlive = false;
		}
		if (collision.gameObject.tag == "Player1" && !(collision.relativeVelocity.magnitude <= 5f))
		{
			UnityEngine.Object.Instantiate(Explosion, transform.position, Quaternion.identity);
			UnityEngine.Object.Instantiate(Explosion, collision.transform.position, Quaternion.identity);
			UnityEngine.Object.Destroy(collision.gameObject);
			UnityEngine.Object.Destroy(gameObject);
			manager.EAlive = false;
			manager.PAlive = false;
		}
	}

	public virtual void OnTriggerEnter(Collider up)
	{
		if (up.gameObject.tag == "PowerUp4")
		{
			int num = 180;
			Vector3 position = up.gameObject.transform.position;
			float num2 = (position.x = num);
			Vector3 vector2 = (up.gameObject.transform.position = position);
			int num3 = 120;
			Vector3 position2 = up.gameObject.transform.position;
			float num4 = (position2.y = num3);
			Vector3 vector4 = (up.gameObject.transform.position = position2);
			up.gameObject.collider.isTrigger = false;
			if (manager.Edeaths > 0)
			{
				manager.Edeaths--;
			}
		}
		if (up.gameObject.tag == "PowerUp3")
		{
			int num5 = 180;
			Vector3 position3 = up.gameObject.transform.position;
			float num6 = (position3.x = num5);
			Vector3 vector6 = (up.gameObject.transform.position = position3);
			int num7 = 120;
			Vector3 position4 = up.gameObject.transform.position;
			float num8 = (position4.y = num7);
			Vector3 vector8 = (up.gameObject.transform.position = position4);
			up.gameObject.collider.isTrigger = false;
			fireRate = 0f;
			hitsPer = 8;
		}
		if (up.gameObject.tag == "PowerUp2")
		{
			int num9 = 180;
			Vector3 position5 = up.gameObject.transform.position;
			float num10 = (position5.x = num9);
			Vector3 vector10 = (up.gameObject.transform.position = position5);
			int num11 = 120;
			Vector3 position6 = up.gameObject.transform.position;
			float num12 = (position6.y = num11);
			Vector3 vector12 = (up.gameObject.transform.position = position6);
			up.gameObject.collider.isTrigger = false;
			Lift = 7f;
			Pull = 7;
			sheer = 5;
			teer = 5;
		}
		if (up.gameObject.tag == "PowerUp1")
		{
			int num13 = 180;
			Vector3 position7 = up.gameObject.transform.position;
			float num14 = (position7.x = num13);
			Vector3 vector14 = (up.gameObject.transform.position = position7);
			int num15 = 120;
			Vector3 position8 = up.gameObject.transform.position;
			float num16 = (position8.y = num15);
			Vector3 vector16 = (up.gameObject.transform.position = position8);
			up.gameObject.collider.isTrigger = false;
			Clipping.width = 35.8f;
		}
	}

	public virtual IEnumerator OnCollisionStay(Collision landed)
	{
		return new _0024OnCollisionStay_0024120(landed, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
