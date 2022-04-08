function initMap() {
    //Create maps for route finder

    var data = document.getElementById("data").value;
    var south = document.getElementById("south").value;
    var west = document.getElementById("west").value;
    var sl = document.getElementById("sl").value;
    var sv = document.getElementById("sv").value;
    var el = document.getElementById("el").value;
    var ev = document.getElementById("ev").value;
    var pathing = document.getElementById("pathing").value;
    var poly = document.getElementById("poly").value;

    const mainArray = data.split(",");

    let heatmapData = [];
    for (let i = 0; i < mainArray.length; i += 2) {
        heatmapData.push(new google.maps.LatLng(mainArray[i], mainArray[i + 1]));
    }
    const pathArray = pathing.split(",");
    console.log(pathArray);


    var provo = new google.maps.LatLng(west, south);
    const start = new google.maps.LatLng(sv, sl);
    const end = new google.maps.LatLng(ev, el);

    map = new google.maps.Map(document.getElementById('map'), {
        center: provo,
        zoom: 12,
        mapTypeId: 'satellite'
    });

    var heatmap = new google.maps.visualization.HeatmapLayer({
        data: heatmapData
    });
    heatmap.setMap(map);

    let latLngArr = google.maps.geometry.encoding.decodePath(poly)
    let rawLatLngArr = []
    for (var i = 0; i < latLngArr.length; i++) {
        rawLatLngArr.push(latLngArr[i].toJSON())
    }
    const flightPath = new google.maps.Polyline({
        path: rawLatLngArr,
        geodesic: true,
        strokeColor: "#228DE7",
        strokeOpacity: 1.0,
        strokeWeight: 5,
    });

    flightPath.setMap(map);


}