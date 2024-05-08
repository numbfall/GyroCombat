using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class splash : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SelfDestruct_0024112 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal splash _0024self__0024113;

			public _0024(splash self_)
			{
				_0024self__0024113 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 2:
					UnityEngine.Object.Destroy(_0024self__0024113.gameObject);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal splash _0024self__0024114;

		public _0024SelfDestruct_0024112(splash self_)
		{
			_0024self__0024114 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024114);
		}
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		StartCoroutine_Auto(SelfDestruct());
	}

	public virtual IEnumerator SelfDestruct()
	{
		return new _0024SelfDestruct_0024112(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
