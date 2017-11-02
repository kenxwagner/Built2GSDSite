var requestCount = 0;
//counting request of 

function requestTimeOff() {
 
  
  switch(card){
    case 1:
	case 2:
    return "request submitted";
	break;
	case 3:
    case 4:
	return "relax";
	break;
   case 5:
     return "request quota max";
      break;
	case 7:
    case 8:
    case 9:
        case 10:
	return "denied";
	break;
    
  }


}

requestTimeOff(1);
requestTimeOff(4);
requestTimeOff(9);

var someCount = 0;

function assetLocation() {
	var assetNumber = 0;
	while (!assetNumber){
		for (assetNumber < 100)
			console.log("Asset Number: " + assetNumber);
			someCount++;
			assetNumber++;
	}
}

assetLocation(12);
assetLocation(120);