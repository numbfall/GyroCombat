using System;
using UnityEngine;

[Serializable]
public class Alive : MonoBehaviour
{
	public GameObject Player1;

	public GameObject Player2;

	public bool PAlive;

	public bool EAlive;

	public int score1;

	public int score2;

	public int Pdeaths;

	public int Edeaths;

	public Movements1 fuelInfoP;

	public Movements2 fuelInfoE;

	public Transform spawn1;

	public Transform spawn2;

	public exSpriteFont font1;

	public exSpriteFont font2;

	public charSelection selected;

	public GameObject which1;

	public GameObject which2;

	public GameObject Character1;

	public GameObject Character2;

	public GameObject Character3;

	public GameObject Character8;

	public GameObject Character9;

	public GameObject Character0;

	public int selected1;

	public int selected2;

	public string level;

	public int nextlevel;

	public GameObject PowerUp1;

	public GameObject PowerUp2;

	public GameObject PowerUp3;

	public GameObject PowerUp4;

	public Transform powerupSpawn;

	public GameObject clone1;

	public GameObject clone2;

	public GameObject clone3;

	public GameObject clone4;

	public bool pause;

	public int countdown;

	public Alive()
	{
		PAlive = true;
		EAlive = true;
		countdown = 5;
	}

	public virtual void Start()
	{
		nextlevel = PlayerPrefs.GetInt("levelcount", 1);
		if (nextlevel == 1)
		{
			level = "cloud2";
		}
		if (nextlevel == 2)
		{
			level = "underwater";
		}
		if (nextlevel == 3)
		{
			level = "space";
		}
		selected = (charSelection)GameObject.FindWithTag("Manager").GetComponent(typeof(charSelection));
		selected1 = PlayerPrefs.GetInt("Player1", 1);
		selected2 = PlayerPrefs.GetInt("Player2", 1);
		if (selected1 == 1)
		{
			which1 = Character1;
		}
		if (selected1 == 2)
		{
			which1 = Character2;
		}
		if (selected1 == 3)
		{
			which1 = Character3;
		}
		if (selected2 == 1)
		{
			which2 = Character8;
		}
		if (selected2 == 2)
		{
			which2 = Character9;
		}
		if (selected2 == 3)
		{
			which2 = Character0;
		}
		Player1 = (GameObject)UnityEngine.Object.Instantiate(which1, spawn1.position, Quaternion.identity);
		Player2 = (GameObject)UnityEngine.Object.Instantiate(which2, spawn2.position, Quaternion.identity);
		InvokeRepeating("PowerUpSpawn", 10f, 20f);
	}

	public virtual void Update()
	{
		if (Input.GetKeyUp(KeyCode.Escape) && !pause)
		{
			Time.timeScale = 0f;
			font1.text = "'DEL' - selection";
			font2.text = "'ESC' - resume";
			pause = true;
		}
		else if (Input.GetKeyUp(KeyCode.Escape) && pause)
		{
			Time.timeScale = 1f;
			font1.text = score1.ToString();
			font2.text = ": " + score2.ToString();
			pause = false;
		}
		if (nextlevel > 4)
		{
			Time.timeScale = 0f;
		}
		if (Pdeaths == 10 || (Edeaths == 10 && nextlevel < 5))
		{
			Invoke("NextLevel", 5f);
		}
		if (!PAlive)
		{
			PAlive = true;
			Invoke("InstantiatePAlive", 3f);
			Pdeaths++;
			UpdateElementText();
		}
		if (!EAlive)
		{
			EAlive = true;
			Invoke("InstantiateEAlive", 3f);
			Edeaths++;
			UpdateElementText();
		}
	}

	public virtual void InstantiatePAlive()
	{
		if (GameObject.FindGameObjectsWithTag("Player2").Length > 0)
		{
			if (!(Vector3.Distance(spawn1.transform.position, GameObject.FindWithTag("Player2").transform.position) >= 150f))
			{
				UnityEngine.Object.Instantiate(which1, spawn2.position, Quaternion.identity);
			}
			else
			{
				UnityEngine.Object.Instantiate(which1, spawn1.position, Quaternion.identity);
			}
		}
		else
		{
			UnityEngine.Object.Instantiate(which1, spawn1.position, Quaternion.identity);
		}
	}

	public virtual void InstantiateEAlive()
	{
		if (GameObject.FindGameObjectsWithTag("Player1").Length > 0)
		{
			if (!(Vector3.Distance(spawn2.transform.position, GameObject.FindWithTag("Player1").transform.position) >= 150f))
			{
				UnityEngine.Object.Instantiate(which2, spawn1.position, Quaternion.identity);
			}
			else
			{
				UnityEngine.Object.Instantiate(which2, spawn2.position, Quaternion.identity);
			}
		}
		else
		{
			UnityEngine.Object.Instantiate(which2, spawn2.position, Quaternion.identity);
		}
	}

	public virtual void UpdateElementText()
	{
		if (Pdeaths < 10)
		{
			score1 = Pdeaths;
		}
		font1.text = score1.ToString();
		if (Edeaths < 10)
		{
			score2 = Edeaths;
		}
		font2.text = ": " + score2.ToString();
		if (Pdeaths == 10)
		{
			font1.text = "Player 2";
			font2.text = "WINS the round";
		}
		if (Edeaths == 10)
		{
			font1.text = "Player 1";
			font2.text = "WINS the round";
		}
	}

	public virtual void PowerUpSpawn()
	{
		switch (UnityEngine.Random.Range(0, 5))
		{
		case 1:
			clone1 = (GameObject)UnityEngine.Object.Instantiate(PowerUp1, powerupSpawn.position, Quaternion.identity);
			UnityEngine.Object.Destroy(clone1, 15f);
			break;
		case 2:
			clone2 = (GameObject)UnityEngine.Object.Instantiate(PowerUp2, powerupSpawn.position, Quaternion.identity);
			UnityEngine.Object.Destroy(clone2, 15f);
			break;
		case 3:
			clone3 = (GameObject)UnityEngine.Object.Instantiate(PowerUp3, powerupSpawn.position, Quaternion.identity);
			UnityEngine.Object.Destroy(clone3, 15f);
			break;
		case 4:
			clone4 = (GameObject)UnityEngine.Object.Instantiate(PowerUp4, powerupSpawn.position, Quaternion.identity);
			UnityEngine.Object.Destroy(clone4, 15f);
			break;
		}
	}

	public virtual void NextLevel()
	{
		nextlevel++;
		Application.LoadLevel(nextlevel);
		PlayerPrefs.SetInt("levelcount", nextlevel);
	}

	public virtual void Main()
	{
	}
}
