import {Map, LatLng, TileLayer, Marker, Circle, LeafletMouseEvent} from 'leaflet' ;
import {doGetRequest, APIRequestResponse} from "../APIHelper"
import {FisheryMapData} from "../DataEntities"

class HomeMapController {

    mapsPlaceholder: Array<Map> = [];
    
    constructor() {
        this.WirePageEvents();
        this.UpdateFisheryMap();
    }
    
    WirePageEvents(){
        
        //Wire Map toggle link 
        let toggleMapAnchor: HTMLAnchorElement = document.getElementById("lnkToggleMapSize") as HTMLAnchorElement;
        
        if(toggleMapAnchor) {
            toggleMapAnchor.addEventListener("click", () => {
                this.ToggleMapSize();
            })
        }
    }
    
    UpdateFisheryMap() {

        doGetRequest("/apiv1/fisheries/all").then((response) => {
            if(response.success) {
                let mapPoints: Array<FisheryMapData> = Object.assign(new Array<FisheryMapData>(), response.jsonData)
                this.FillAndFomatMapData(mapPoints)
            }    
        });
    }
    
    ToggleMapSize(){
        let toggleMapAnchor: HTMLAnchorElement = document.getElementById("lnkToggleMapSize") as HTMLAnchorElement;
        let homeMap: HTMLDivElement = document.getElementById("homeMap") as HTMLDivElement;
        
        if(toggleMapAnchor.textContent == "Expand Map"){
            homeMap.classList.remove("smallHomeMap");
            homeMap.classList.add("expandedHomeMap");
            toggleMapAnchor.textContent = "Collapse Map";
        }
        else
        {
            homeMap.classList.remove("expandedHomeMap");
            homeMap.classList.add("smallHomeMap");
            toggleMapAnchor.textContent = "Expand Map";
        }
        
        // @ts-ignore
        let map: Map = this.mapsPlaceholder.pop();
        map.invalidateSize();
        this.mapsPlaceholder.push(map);
        
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
    new HomeMapController();
}