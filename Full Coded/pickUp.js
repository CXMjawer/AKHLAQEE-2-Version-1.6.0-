//Jimmy Vegas Unity Tutorial
//This script will allow you to pick up and move objects


var target : Transform;


function Update () {

}

function OnMouseDown() {

		this.transform.position = target.position;
		this.transform.parent = GameObject.Find("3RD Person").transform;
		this.transform.parent = GameObject.Find("Character").transform;
		
	}


function OnMouseUp() {

		this.transform.parent = GameObject.Find("3RD Person").transform;
		this.transform.parent = null;
		
	}
