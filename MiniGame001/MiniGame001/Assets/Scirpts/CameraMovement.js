var myTimer : float = 0.0;
var i : float = 0.01;
function Update () {
myTimer+=Time.deltaTime;
transform.position = Vector3((transform.position.x),((transform.position.y+i)),
(transform.position.z));
if(myTimer>=10)
	{
	i+=0.01;
	}
	if(myTimer>10)
	{
	myTimer=0;
	}	
}