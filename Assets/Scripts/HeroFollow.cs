using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroFollow : MonoBehaviour {
	public HeroRabit rabit;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//Отримали доступ до компонентів Transform кроля та камери відповідно 
		//(this бо скріпт застосовується до камери)
		Transform rabit_transform = rabit.transform;
		Transform camera_transform = this.transform;

		//Отримали доступ до координат кролика
		Vector3 rabit_position = rabit_transform.position;
		Vector3 camera_position = camera_transform.position;

		//Задаємо рух камери відповіднім до руху кроля
		camera_position.x = rabit_position.x;
		camera_position.y = rabit_position.y;

		//Встановлюємо координати камери
		camera_transform.position = camera_position;
	}
}