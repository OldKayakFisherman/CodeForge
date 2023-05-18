import 'leaflet' ;
import {doGetRequest, APIRequestResponse} from "../APIHelper.js"
function updateFisheryMap(){
    
    doGetRequest("/apiv1/fisheries/all").then((response) => {
        console.log(response);
    });
}


window.onload = () => {
    updateFisheryMap();
}