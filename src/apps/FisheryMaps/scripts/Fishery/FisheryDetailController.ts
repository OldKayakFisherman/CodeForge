import {FisheryData} from "../DataEntities";
import {LatLng, Map, TileLayer} from "leaflet";
import {doGetRequest} from "../APIHelper"
class FisheryDetailController
{
    //@ts-ignore
    fisheryPlaceholder: Array<FisheryData> = [];
    mapsPlaceholder: Array<Map> = [];
    constructor() {
        this.Initialize();
        this.WireEvents();
    }
    
    Initialize(){
       
        let modelNonce: HTMLInputElement = document.getElementById('hdnModelNonce') as HTMLInputElement;
        
        if(modelNonce && modelNonce.value)
        {
            
            doGetRequest(`/apiv1/fisheries/fishery/${modelNonce.value}`).then((response) => {
                
                if(response.success) {
                    this.fisheryPlaceholder.push(Object.assign(new FisheryData(), response.jsonData));
                    this.FormatMap();
                }
            });
            
        }
    }
    WireEvents(): void
    {
        
    }
    
    FormatMap(){
        if(this.fisheryPlaceholder.length > 0)
        {
            console.log("Formatting map ...");
            
            let fishery: FisheryData = this.fisheryPlaceholder.pop() as FisheryData;
            
            let map = new Map('detailMap', {
                center: new LatLng(fishery.latitude, fishery.longitude),
                zoom: 14,
            });

            new TileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
                maxZoom: 19,
                attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
            }).addTo(map);


            this.mapsPlaceholder.push(map);
            this.fisheryPlaceholder.push(fishery);
        }
    }
}



window.onload = () => {
    new FisheryDetailController();
}