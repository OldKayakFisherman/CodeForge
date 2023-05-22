import {Map, LatLng, TileLayer, Marker, Circle, LeafletMouseEvent} from 'leaflet' ;
import {doGetRequest, APIRequestResponse} from "../APIHelper"
import {FisheryMapData} from "../DataEntities"

class HomeMapController {

    mapsPlaceholder: Array<Map> = [];
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
     
        if(mapPoints.length > 0){
            mapPoints.forEach((mapPoint) => {
                
                let coordinates: LatLng = new LatLng(mapPoint.latitude, mapPoint.longitude);
                
                 let cr = new Circle(coordinates, {
                     color: 'blue',
                     fillColor: '#3486eb',
                     fillOpacity: 0.3,
                     radius: 200
                 });
                 
                 let mapPointContent: HTMLDivElement = document.createElement('div') as HTMLDivElement; 
                 mapPointContent.textContent = mapPoint.name;
                 
                 cr.on('click', (ev: LeafletMouseEvent) =>{
                     this.CenterAndZoomMap(ev.latlng, 12);
                 });
                 
                 cr.bindPopup(mapPointContent)
                 cr.addTo(map);
                    
            });
        }
        
        this.mapsPlaceholder.push(map)
    }
    
    CenterAndZoomMap(coordinates: LatLng, zoomLevel: number): void
    {
        if(this.mapsPlaceholder.length > 0) {
            // @ts-ignore
            let map: Map = this.mapsPlaceholder.pop();
            map.flyTo(coordinates, zoomLevel);
            this.mapsPlaceholder.push(map);
        }
    }
}

window.onload = () => {
    let controller = new HomeMapController();
    controller.UpdateFisheryMap();
}