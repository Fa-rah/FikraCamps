function tranformIntArrayToStringArray(intArray){
    var stringArray=new Array();
    for (var i = 0; i <= intArray.length; i++) {
        stringArray[i]=switchingIntToString(intArray[i]);
    }

return stringArray;
}

function switchingIntToString(number){
    var numberString="";
    switch(number){
        case 1:
            numberString="one" 
        break;      
        case 2:
            numberString="two" 
        break;      
        case 3:
            numberString="three" 
        break;      case 4:
            numberString="four" 
        break;      case 5:
            numberString="five" 
        break;      
        case 6:
            numberString="six" 
        break;
        case 7:
            numberString="seven" 
        break;
        case 8:
            numberString="eight" 
        break;
                case 9:
            numberString="nine" 
        break;
                case 10:
            numberString="ten" 
        break;
    }

    return numberString;
} 