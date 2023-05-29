
export class FisheryData {
    name: string
    latitude: number
    longitude: number
    active: boolean
    nonce: string

    constructor() {
        this.name = String();
        this.latitude = 0.0;
        this.longitude = 0.0
        this.active = false
        this.nonce = String();
    }
}


