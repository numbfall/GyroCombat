using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class explosion : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024SelfDestruct_0024109 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal explosion _0024self__0024110;

			public _0024(explosion self_)
			{
				_0024self__0024110 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.8f)) ? 1 : 0);
					break;
				case 2:
					UnityEngine.Object.Destroy(_0024self__0024110.gameObject);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal explosion _0024self__0024111;

		public _0024SelfDestruct_0024109(explosion self_)
		{
			_0024self__0024111 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024111);
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
		return new _0024SelfDestruct_0024109(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
