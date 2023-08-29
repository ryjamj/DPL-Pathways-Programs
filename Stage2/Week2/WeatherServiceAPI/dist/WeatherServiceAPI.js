"use strict";
// Function #1: get API Data paragraphs
async function getAPIDataFunc(latString, lngString) {
    // ---- variables ----
    const apiCheck1String = document.getElementById("apiCheck1ID");
    const apiCheck2String = document.getElementById("apiCheck2ID");
    // ---- API #1 ----
    const api1String = "https://api.weather.gov/points/" + latString + "," + lngString;
    const response = await fetch(api1String); // api call
    console.log(api1String);
    console.log("reponse status: ", response.status, " status text: ", response.statusText);
    // ---- API #2----
    const jsonData = await response.json();
    let api2String = jsonData.properties.forecast;
    // ---- display results, check typeof ----
    // clear what was previously shown
    apiCheck1String.innerHTML = "";
    apiCheck2String.innerHTML = "";
    // show new info
    apiCheck1String.innerHTML = api1String;
    apiCheck2String.innerHTML = api2String;
}
//# sourceMappingURL=WeatherServiceAPI.js.map