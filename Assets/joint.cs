using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joint : MonoBehaviour {

	public GameObject plane;
	public GameObject braco1;
	public GameObject braco2;
	public GameObject braco3;
	public GameObject braco4;
	public GameObject canela1;
	public GameObject canela2;
	public GameObject canela3;
	public GameObject canela4;
	public GameObject corpinho;
	public GameObject cotovelo1;
	public GameObject cotovelo2;
	public GameObject coxa1;
	public GameObject coxa2;
	public GameObject coxa3;
	public GameObject coxa4;
	public GameObject feet1;
	public GameObject feet2;
	public GameObject joelho1;
	public GameObject joelho2;
	public GameObject ombro1;
	public GameObject ombro2;
	public GameObject pescoco1;
	public GameObject pescoco2;
	public GameObject cabeca;
	public GameObject mao1;
	public GameObject mao2;
	public GameObject antebraco1;
	public GameObject antebraco2;
	public GameObject antebraco3;
	public GameObject antebraco4;

	private Joint fixa;
	private Joint dobradica;
	private Joint mola;

	// Use this for initialization
	void Start () 
	{
		plane = GameObject.Find("Plane");
		braco1 = GameObject.Find("braco1");
		braco2 = GameObject.Find("braco2");
		braco3 = GameObject.Find("braco3");
		braco4 = GameObject.Find("braco4");
		canela1 = GameObject.Find("Canela1");
		canela2 = GameObject.Find("Canela2");
		canela3 = GameObject.Find("Canela3");
		canela4 = GameObject.Find("Canela4");
		corpinho = GameObject.Find ("Corpinho");
		cotovelo1 = GameObject.Find ("cotovelo1");
		cotovelo2 = GameObject.Find ("cotovelo2");
		coxa1 = GameObject.Find ("Coxa1");
		coxa2 = GameObject.Find ("Coxa2");
		coxa3 = GameObject.Find ("Coxa3");
		coxa4 = GameObject.Find ("Coxa4");
		feet1 = GameObject.Find("Feet1");
		feet2 = GameObject.Find("Feet2");
		joelho1 = GameObject.Find ("Joelho1");
		joelho2 = GameObject.Find ("Joelho2");
		ombro1 = GameObject.Find ("Ombro1");
		ombro2 = GameObject.Find ("Ombro2");
		pescoco1 = GameObject.Find ("Pescoco1");
		pescoco2 = GameObject.Find ("Pescoco2");
		cabeca = GameObject.Find ("Sphere");
		mao1 = GameObject.Find ("mao1");
		mao2 = GameObject.Find ("mao2");
		antebraco1 = GameObject.Find ("antebraco1");
		antebraco2 = GameObject.Find ("antebraco2");
		antebraco3 = GameObject.Find ("antebraco3");
		antebraco4 = GameObject.Find ("antebraco4");

		// Joelho pra baixo esquerdo
		fixa = feet1.AddComponent<FixedJoint>();
		fixa.connectedBody = canela1.GetComponent<Rigidbody>();
		fixa = canela1.AddComponent<FixedJoint> ();
		fixa.connectedBody = canela4.GetComponent<Rigidbody> ();

		dobradica = joelho1.AddComponent<HingeJoint>();
		fixa = canela4.AddComponent<FixedJoint> ();
		fixa.connectedBody = joelho1.GetComponent<Rigidbody> ();

		// Joelho pra cima esquerdo
		fixa = joelho1.AddComponent<FixedJoint> ();
		fixa.connectedBody = coxa2.GetComponent<Rigidbody> ();
		fixa = coxa2.AddComponent<FixedJoint> ();
		fixa.connectedBody = coxa4.GetComponent<Rigidbody> ();
		fixa = coxa4.AddComponent<FixedJoint> ();
		fixa.connectedBody = corpinho.GetComponent<Rigidbody> ();

		// Joelho pra baixo direito
		fixa = feet2.AddComponent<FixedJoint>();
		fixa.connectedBody = canela2.GetComponent<Rigidbody>();
		fixa = canela2.AddComponent<FixedJoint> ();
		fixa.connectedBody = canela3.GetComponent<Rigidbody> ();

		dobradica = joelho2.AddComponent<HingeJoint>();
		fixa = canela3.AddComponent<FixedJoint> ();
		fixa.connectedBody = joelho2.GetComponent<Rigidbody> ();

		// Joelho pra cima direito
		fixa = joelho2.AddComponent<FixedJoint> ();
		fixa.connectedBody = coxa1.GetComponent<Rigidbody> ();
		fixa = coxa1.AddComponent<FixedJoint> ();
		fixa.connectedBody = coxa3.GetComponent<Rigidbody> ();
		fixa = coxa3.AddComponent<FixedJoint> ();
		fixa.connectedBody = corpinho.GetComponent<Rigidbody> ();

		// Braço pra frente do cotovelo esquerdo
		fixa = mao2.AddComponent<FixedJoint>();
		fixa.connectedBody = antebraco4.GetComponent<Rigidbody>();
		fixa = antebraco4.AddComponent<FixedJoint> ();
		fixa.connectedBody = antebraco3.GetComponent<Rigidbody> ();
		mola = antebraco3.AddComponent<SpringJoint> ();
		mola.connectedBody = cotovelo2.GetComponent<Rigidbody> ();

		//cotovelo pra tras esquerso
		fixa = cotovelo2.AddComponent<FixedJoint> ();
		fixa.connectedBody = braco4.GetComponent<Rigidbody> ();
		fixa = braco4.AddComponent<FixedJoint> ();
		fixa.connectedBody = braco1.GetComponent<Rigidbody> ();
		mola = braco1.AddComponent<SpringJoint> ();
		mola.connectedBody = ombro1.GetComponent<Rigidbody> ();
		fixa = ombro1.AddComponent<FixedJoint> ();
		fixa.connectedBody = corpinho.GetComponent<Rigidbody> ();


		// Braço pra frente do cotovelo direito
		fixa = mao1.AddComponent<FixedJoint>();
		fixa.connectedBody = antebraco2.GetComponent<Rigidbody>();
		fixa = antebraco2.AddComponent<FixedJoint> ();
		fixa.connectedBody = antebraco1.GetComponent<Rigidbody> ();
		mola = antebraco1.AddComponent<SpringJoint> ();
		mola.connectedBody = cotovelo1.GetComponent<Rigidbody> ();

		//cotovelo pra tras direito
		fixa = cotovelo1.AddComponent<FixedJoint> ();
		fixa.connectedBody = braco3.GetComponent<Rigidbody> ();
		fixa = braco3.AddComponent<FixedJoint> ();
		fixa.connectedBody = braco2.GetComponent<Rigidbody> ();
		mola = braco2.AddComponent<SpringJoint> ();
		mola.connectedBody = ombro2.GetComponent<Rigidbody> ();
		fixa = ombro2.AddComponent<FixedJoint> ();
		fixa.connectedBody = corpinho.GetComponent<Rigidbody> ();

		// Cabeça pra baixo

		fixa = cabeca.AddComponent<FixedJoint> ();
		fixa.connectedBody = pescoco1.GetComponent<Rigidbody> ();

		fixa = pescoco1.AddComponent<FixedJoint> ();
		fixa.connectedBody = pescoco2.GetComponent<Rigidbody> ();

		fixa = pescoco2.AddComponent<FixedJoint> ();
		fixa.connectedBody = corpinho.GetComponent<Rigidbody> ();


		//mola = corpinho.AddComponent<SpringJoint>();
		//mola.connectedBody = canela1.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update ()
	{


	}
}
