﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationLogic
{
	public partial class QueryProcessor
	{
		// Ovo tu će biti jedan prekrasan fajl sa puno koda

		// Trebamo implementirati funkcije za slijedeće odnose.
		//
		//partner/muž/žena
		//potomak/sin/kćer
		//roditelj/majka/otac
		// ----------------------------- ovo je praktički već napravljeno
		//brat/sestra
		//sestrična/bratić
		//baka/djed
		// ---------------------------- do ovdje apsolutno moramo imati xD
		//stric, strina, ujak, ujna, teta, tetak
		//punac/punica
		//svekar/svekrva
		//zet/nevjesta
		//šogor/šogorica
		// -------------------------- do ovdje je bitno
		//polubrat/polusestra -- ja bi ovo izbacio, polubrat je isto brat
		//potomak 2. koljeno/unuk/unuka
		//potomak 3. koljeno/praunuk/praunuka
		//roditelj 2. koljeno/prabaka/pradjed
		//roditelj 3. koljeno/šukunbaka/šukundjed
		

		// 


		public void DodajBaku(string[] parametri)
		{
			//TODO
			throw new System.NotImplementedException("TODO DodajBaku");
		}

	//	public void 

		public void PromijeniPodatke(string[] parametri)
		{
			//TODO 
			//System.Console.WriteLine


			throw new System.NotImplementedException("TODO PromijeniPodatke");
		}

		public void IspisiDrvo(string[] parametri)
		{

			throw new System.NotImplementedException("TODO IspisiDrvo");
		}

		// definiraj novi exception, koristimo ga da program zna kada korisnik želi izaći iz programa
		public class QuitException : Exception { };

		public void Izlaz(string[] parametri)
		{
			throw new QuitException();
		}
	}
}
