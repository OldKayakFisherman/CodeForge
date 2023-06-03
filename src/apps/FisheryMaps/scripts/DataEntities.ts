
export class FisheryData {
    name: string
    latitude: number
    longitude: number
    active: boolean
    nonce: string
    hotspots: HotSpot[]
    
    constructor() {
        this.name = String();
        this.latitude = 0.0;
        this.longitude = 0.0
        this.active = false
        this.nonce = String();
        this.hotspots = []
    }
}

export class MapPoint
{
    latitude: number
    longitude: number

    constructor() {
        this.latitude = 0.0;
        this.longitude = 0.0
    }
}

export class HotSpot
{
    species: string
    season: string
    technique: string[]
    coordinates: MapPoint[]
    
    constructor() {
        this.species = String()
        this.season = String()
        this.technique = []
        this.coordinates = []
    }
}

