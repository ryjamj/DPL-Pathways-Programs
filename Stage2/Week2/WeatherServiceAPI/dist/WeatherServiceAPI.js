"use strict";
// Function #1: get API Data paragraphs
async function getAPIDataFunc(latString, lngString) {
    // ---- variables ----
    const apiCheck1String = document.getElementById("apiCheck1ID");
    const apiCheck2String = document.getElementById("apiCheck2ID");
    const myDaysP = document.getElementById("myDaysP");
    const myWeatherP = document.getElementById("myWeatherP");
    const myTempP = document.getElementById("myTempP");
    // ---- API #1 ----
    let api1String = "https://api.weather.gov/points/" + latString + "," + lngString;
    let response1 = await fetch(api1String); // api call
    console.log(api1String);
    console.log("reponse status: ", response1.status, " status text: ", response1.statusText);
    let jsonData = await response1.json();
    // ---- API #2----
    let api2String = jsonData.properties.forecast;
    let response2 = await fetch(api2String); // api call
    console.log(api2String);
    console.log("reponse status: ", response2.status, " status text: ", response2.statusText);
    let jsonData2 = await response2.json();
    let days = jsonData2.properties.periods.length; // i think this 'day's is an array.
    // ---- display results, check typeof ----
    // clear what was previously shown
    apiCheck1String.innerHTML = "";
    apiCheck2String.innerHTML = "";
    myDaysP.innerHTML = "";
    myWeatherP.innerHTML = "";
    myTempP.innerHTML = "";
    // show new info
    apiCheck1String.innerHTML = api1String;
    apiCheck2String.innerHTML = api2String;
    for (let i = 0; i < days; i++) {
        if (myDaysP != null) {
            myDaysP.innerHTML += jsonData2.properties.periods[i].name + "<br><br>";
        }
        if (myWeatherP != null) {
            myWeatherP.innerHTML += jsonData2.properties.periods[i].shortForecast + "<br><br>";
        }
        if (myTempP != null) {
            myTempP.innerHTML += jsonData2.properties.periods[i].temperature + " degrees Farenheit" + "<br><br>";
        }
    }
}
//# sourceMappingURL=WeatherServiceAPI.js.map