using UnityEngine;
using System.Collections;

public class SPon : MonoBehaviour
{
	public Vector3 Speed;
	// Use this for initialization
	void Start ()
	{
		
	}
	// Update is called once per frame
	void Update ()
	{
		var offset = new Vector3 (this.Speed.x * Time.deltaTime, this.Speed.y * Time.deltaTime, 0);
		this.MovePosition (offset);
	}
	
	public void SetPosition (Vector3 pos)
	{
		this.transform.position = pos;
	}
	
	public void MovePosition (Vector3 offset)
	{
		var p = this.transform.position;
		this.transform.position = new Vector3 (p.x + offset.x, p.y + offset.y, p.z);
	}

	void OnEnable ()
	{
		//イベントリスナをセット
		TouchManager.Instance.Swipe += OnSwipe;
		TouchManager.Instance.TouchStart += OnTouchStart;
		TouchManager.Instance.TouchEnd += OnTouchEnd;
		TouchManager.Instance.Flick += OnFlick;
	}
	
	void OnDisable ()
	{
		//イベントリスナを解除
		TouchManager.Instance.Swipe -= OnSwipe;
		TouchManager.Instance.TouchStart -= OnTouchStart;
		TouchManager.Instance.TouchEnd -= OnTouchEnd;
		TouchManager.Instance.Flick -= OnFlick;
	}
	
	void OnTouchStart (object sender, TouchEventArgs e)
	{
		//タッチ開始時に呼び出されます。
	}
	
	void OnTouchEnd (object sender, TouchEventArgs e)
	{
		//タッチ終了時に呼び出されます。
	}
	
	void OnSwipe (object sender, SwipeEventArgs e)
	{
		//スワイプ中に呼び出されます。
	}
	
	void OnFlick (object sender, FlickEventArgs e)
	{
		//フリック検出時に呼び出されます。
	}
}
