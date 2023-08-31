const map = L.map('map').setView([40.739, -111.91], 7);

L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19,
    attribution: '© OpenStreetMap'
}).addTo(map);


var popup = L.popup();
function onMapClick(e) {

    let latString = e.latlng.lat.toString()
    let lngString = e.latlng.lng.toString();

    document.getElementById("latP").innerHTML = latString;
    document.getElementById("lngP").innerHTML = lngString;

    popup
        .setLatLng(e.latlng)
        .setContent("You clicked the map at " + e.latlng.toString())
        .openOn(map);

    // api function
    getAPIDataFunc(latString, lngString)
}
map.on('click', onMapClick);