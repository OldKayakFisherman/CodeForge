import {FisheryData} from "../DataEntities";
import {LatLng, Map, Polygon, TileLayer} from "leaflet";
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
            
            let fishery: FisheryData = this.fisheryPlaceholder.pop() as FisheryData;
            
            
            let map = new Map('detailMap', {
                center: new LatLng(fishery.latitude, fishery.longitude),
                zoom: 14,
            });

            new TileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
                maxZoom: 19,
                attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
            }).addTo(map);

            if(fishery.hotspots.length > 0)
            {
                for (let i = 0;i<fishery.hotspots.length; i++)
                {
                    let hotspot = fishery.hotspots[i];
                    let mapCoordinates = 
                        hotspot.coordinates.map(({
                            latitude,
                            longitude
                        }) => {
                        return new LatLng( latitude, longitude);
                    });
                    
                    let hotspotArea = new Polygon(mapCoordinates).addTo(map);
                    
                    let techniqueDiv: HTMLDivElement = document.createElement("div") as HTMLDivElement;
                    let techniqueH5: HTMLHeadingElement = document.createElement("h5") as HTMLHeadingElement;
                    let techniqueList: HTMLUListElement = document.createElement("ul") as HTMLUListElement;
                    
                   
                    
                    for (let i = 0; i<hotspot.techniques.length; i++){
                        let liItem: HTMLLIElement = document.createElement("li") as HTMLLIElement;
                        liItem.textContent = hotspot.techniques[i];
                        techniqueList.appendChild(liItem);
                    }
                    
                    techniqueH5.textContent = "Best Techniques";
                    
                    techniqueDiv.appendChild(techniqueH5);
                    techniqueDiv.appendChild(techniqueList);
                    
                    hotspotArea.bindPopup(techniqueDiv);
                    hotspotArea.setStyle({color:"red", weight:2})
                }
            }
            
            
            this.mapsPlaceholder.push(map);
            this.fisheryPlaceholder.push(fishery);
        }
    }
}



window.onload = () => {
    new FisheryDetailController();
}