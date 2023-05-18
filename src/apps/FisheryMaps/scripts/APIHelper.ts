export class APIRequestResponse {
    success: boolean;
    serverResponse: string;
    error: string ;
    
    constructor() {
        this.serverResponse = String();
        this.success = false;
        this.error = String();
    }
}

export async function doGetRequest(url:string){
    return await doBaseRequest('GET', url, "");
}

export async function doPostRequest(url:string, payload:string){
    return await doBaseRequest('POST', url, payload);
}

export async function doPutRequest(url:string, payload:string){
    return await doBaseRequest('PUT', url, payload);
}

export async function doDeleteRequest(url:string){
    return await doBaseRequest("DELETE", url, "");
}

async function doBaseRequest(verb:string, url:string, payload:string){

    let apiResponse: APIRequestResponse = new APIRequestResponse();

    try {
        const response = await fetch(url, {
            method: verb,
            body: JSON.stringify(payload),
            headers: {
                'Content-Type': 'application/json',
                Accept: 'application/json',
            },
        });
        
        apiResponse.success = response.ok;
        apiResponse.serverResponse = response.statusText;

    }
    catch (error: any) {

        apiResponse.success = false;

        if (error instanceof Error) {
            apiResponse.error = error.message;
        } else {
            apiResponse.error = error.toString();
        }
    }

    return apiResponse;
}
