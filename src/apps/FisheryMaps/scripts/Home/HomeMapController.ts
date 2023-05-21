import {Map, LatLng, TileLayer} from 'leaflet' ;
import {doGetRequest, APIRequestResponse} from "../APIHelper"
import {FisheryMapData} from "../DataEntities"

class HomeMapController {
    
    UpdateFisheryMap() {

        doGetRequest("/apiv1/fisheries/all").then((response) => {
            if(response.success) {
                let mapPoints: Array<FisheryMapData> = Object.assign(new Array<FisheryMapData>(), response.jsonData)
                this.FillAndFomatMapData(mapPoints)
            }    
        });
    }
    
    FillAndFomatMapData(mapPoints: Array<FisheryMapData>) {
        
        //39.828175 -98.5795
        let map = new Map('homeMap', {
            center: new LatLng(39.828175, -98.5795),
            zoom: 2,
        });

        new TileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
            maxZoom: 19,
            attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
        }).addTo(map);
     
        
        
    }
}

window.onload = () => {
    let controller = new HomeMapController();
    controller.UpdateFisheryMap();
}