using UnityEngine;
using System.Collections;

public class Enumerations : MonoBehaviour {


    enum Candy {Twix, Milkyway, Snickers, Mnms};
    
	void Start () 
    {
	Candy myCandy;
        
        myCandy = Candy.Twix;
	}
	
	Candy ExchangeCandy (GameObject can)
        
    {
    if(can == Candy.Twix)
         can = Candy.Snickers;
    else if  (can == Candy.Snickers)
         can = Candy.Twix;  
    else if  (can == Candy.Milkyway)
         can = Candy.Mnms;   
    else if  (can == Candy.Mnms)
         can = Candy.Milkyway;  
    }
}
