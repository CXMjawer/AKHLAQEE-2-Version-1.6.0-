using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ReadText: MonoBehaviour
{
        
        StreamReader reader = new StreamReader(@"C:/AKHLAQEE 2 - Game Saves/AllStatus.txt"); 
		public  Text t;
string All;
		    
		     void Start()
		    {
		    
		        
		        All=reader.ReadToEnd();

		        
		        t.text="RECENT: "+All.ToString();
		    }

}