using System;
using UnityEngine;

[Serializable]
public class charSelection : MonoBehaviour
{
	public exSprite big;

	public exSprite small;

	public exSprite card1;

	public exSprite card2;

	public exSprite card3;

	public exSprite card4;

	public exSprite card5;

	public exSprite card6;

	public int selected1;

	public int selected2;

	public virtual void Start()
	{
		int num = 1000;
		Vector3 position = card1.transform.position;
		float num2 = (position.x = num);
		Vector3 vector2 = (card1.transform.position = position);
		int num3 = 1000;
		Vector3 position2 = card2.transform.position;
		float num4 = (position2.x = num3);
		Vector3 vector4 = (card2.transform.position = position2);
		int num5 = 1000;
		Vector3 position3 = card3.transform.position;
		float num6 = (position3.x = num5);
		Vector3 vector6 = (card3.transform.position = position3);
		int num7 = 1000;
		Vector3 position4 = card4.transform.position;
		float num8 = (position4.x = num7);
		Vector3 vector8 = (card4.transform.position = position4);
		int num9 = 1000;
		Vector3 position5 = card5.transform.position;
		float num10 = (position5.x = num9);
		Vector3 vector10 = (card5.transform.position = position5);
		int num11 = 1000;
		Vector3 position6 = card6.transform.position;
		float num12 = (position6.x = num11);
		Vector3 vector12 = (card6.transform.position = position6);
		PlayerPrefs.SetInt("levelcount", 1);
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			int num = -102;
			Vector3 position = card1.transform.position;
			float num2 = (position.x = num);
			Vector3 vector2 = (card1.transform.position = position);
			int num3 = 1000;
			Vector3 position2 = card2.transform.position;
			float num4 = (position2.x = num3);
			Vector3 vector4 = (card2.transform.position = position2);
			int num5 = 1000;
			Vector3 position3 = card3.transform.position;
			float num6 = (position3.x = num5);
			Vector3 vector6 = (card3.transform.position = position3);
			selected1 = 1;
			PlayerPrefs.SetInt("Player1", selected1);
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			int num7 = -102;
			Vector3 position4 = card2.transform.position;
			float num8 = (position4.x = num7);
			Vector3 vector8 = (card2.transform.position = position4);
			int num9 = 1000;
			Vector3 position5 = card1.transform.position;
			float num10 = (position5.x = num9);
			Vector3 vector10 = (card1.transform.position = position5);
			int num11 = 1000;
			Vector3 position6 = card3.transform.position;
			float num12 = (position6.x = num11);
			Vector3 vector12 = (card3.transform.position = position6);
			selected1 = 2;
			PlayerPrefs.SetInt("Player1", selected1);
		}
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			int num13 = -102;
			Vector3 position7 = card3.transform.position;
			float num14 = (position7.x = num13);
			Vector3 vector14 = (card3.transform.position = position7);
			int num15 = 1000;
			Vector3 position8 = card2.transform.position;
			float num16 = (position8.x = num15);
			Vector3 vector16 = (card2.transform.position = position8);
			int num17 = 1000;
			Vector3 position9 = card1.transform.position;
			float num18 = (position9.x = num17);
			Vector3 vector18 = (card1.transform.position = position9);
			selected1 = 3;
			PlayerPrefs.SetInt("Player1", selected1);
		}
		if (Input.GetKeyDown(KeyCode.Alpha8))
		{
			int num19 = 102;
			Vector3 position10 = card4.transform.position;
			float num20 = (position10.x = num19);
			Vector3 vector20 = (card4.transform.position = position10);
			int num21 = 1000;
			Vector3 position11 = card5.transform.position;
			float num22 = (position11.x = num21);
			Vector3 vector22 = (card5.transform.position = position11);
			int num23 = 1000;
			Vector3 position12 = card6.transform.position;
			float num24 = (position12.x = num23);
			Vector3 vector24 = (card6.transform.position = position12);
			selected2 = 1;
			PlayerPrefs.SetInt("Player2", selected2);
		}
		if (Input.GetKeyDown(KeyCode.Alpha9))
		{
			int num25 = 102;
			Vector3 position13 = card5.transform.position;
			float num26 = (position13.x = num25);
			Vector3 vector26 = (card5.transform.position = position13);
			int num27 = 1000;
			Vector3 position14 = card4.transform.position;
			float num28 = (position14.x = num27);
			Vector3 vector28 = (card4.transform.position = position14);
			int num29 = 1000;
			Vector3 position15 = card6.transform.position;
			float num30 = (position15.x = num29);
			Vector3 vector30 = (card6.transform.position = position15);
			selected2 = 2;
			PlayerPrefs.SetInt("Player2", selected2);
		}
		if (Input.GetKeyDown(KeyCode.Alpha0))
		{
			int num31 = 102;
			Vector3 position16 = card6.transform.position;
			float num32 = (position16.x = num31);
			Vector3 vector32 = (card6.transform.position = position16);
			int num33 = 1000;
			Vector3 position17 = card5.transform.position;
			float num34 = (position17.x = num33);
			Vector3 vector34 = (card5.transform.position = position17);
			int num35 = 1000;
			Vector3 position18 = card4.transform.position;
			float num36 = (position18.x = num35);
			Vector3 vector36 = (card4.transform.position = position18);
			selected2 = 3;
			PlayerPrefs.SetInt("Player2", selected2);
		}
		float z = small.transform.rotation.z + 1f * Time.deltaTime;
		Quaternion rotation = small.transform.rotation;
		float num37 = (rotation.z = z);
		Quaternion quaternion2 = (small.transform.rotation = rotation);
		float z2 = big.transform.rotation.z - 1f * Time.deltaTime;
		Quaternion rotation2 = big.transform.rotation;
		float num38 = (rotation2.z = z2);
		Quaternion quaternion4 = (big.transform.rotation = rotation2);
		if (Input.GetKeyDown(KeyCode.Return))
		{
			Application.LoadLevel("mountain");
		}
		if (Input.GetKeyDown(KeyCode.Delete) && Application.loadedLevel != 0)
		{
			Application.LoadLevel("selection");
		}
		else if (Input.GetKeyDown(KeyCode.Delete))
		{
			Application.Quit();
		}
	}

	public virtual void Main()
	{
	}
}
