// Function #1: get API Data paragraphs
async function getAPIDataFunc(latString: string, lngString: string) {

    // ---- variables ----
    const apiCheck1String = document.getElementById("apiCheck1ID") as HTMLInputElement;
    const apiCheck2String = document.getElementById("apiCheck2ID") as HTMLInputElement;

    // ---- API #1 ----
    const api1String: string = "https://api.weather.gov/points/" + latString + "," + lngString;
    const response1: Response = await fetch(api1String); // api call
    console.log(api1String);
    console.log("reponse status: ", response1.status, " status text: ", response1.statusText);

    // ---- API #2----
    const jsonData = await response1.json();
    let api2String: string = jsonData.properties.forecast;
    const response2: Response = await fetch(api2String); // api call
    console.log(api2String);
    console.log("reponse status: ", response2.status, " status text: ", response2.statusText);



    // ---- display results, check typeof ----
    // clear what was previously shown
    apiCheck1String.innerHTML = "";
    apiCheck2String.innerHTML = "";
    // show new info
    apiCheck1String.innerHTML = api1String;
    apiCheck2String.innerHTML = api2String;
}


