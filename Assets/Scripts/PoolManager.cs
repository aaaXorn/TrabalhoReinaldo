using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
	//objeto da lista
	[SerializeField]
	private GameObject PoolObj;

	//lista de objetos pro pooling
	private List<GameObject> PoolList;

	//objetos dentro da pool
	[SerializeField]
	private int objs_pooled;

	//inicializa a pool
	private void Start()
	{
		PoolList = new List<GameObject>();
		GameObject obj;

		for (int i = 0; i < objs_pooled; i++)
		{
			obj = Instantiate(PoolObj);
			obj.SetActive(false);
			PoolList.Add(obj);
		}
	}

	//pega um objeto da pool
	public GameObject GetFromPool()
	{
		for (int i = 0; i < objs_pooled; i++)
		{
			//n�o deixa pegar objetos j� ativos na cena
			if (!PoolList[i].activeInHierarchy)
			{
				return PoolList[i];
			}
		}

		//se todos os objetos est�o ativos
		print("No inactive object in pool.");
		return null;
	}
}