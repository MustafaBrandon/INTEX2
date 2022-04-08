//Create maps for details page

let utmX = document.getElementById("utmX").value;
let utmY = document.getElementById("utmY").value;

let lat;
let long;
let addr;

axios.post('https://7o1vcvfox2.execute-api.us-east-1.amazonaws.com/default/utmToLatLong', {
    "body": "{\"utmX\": " + utmX + ", \"utmY\": " + utmY + "}"
}).then(res => {
    console.log(res);
    let data = JSON.parse(res.data);
    lat = data.lat;
    long = data.lon;

    let moreUrl = 'https://maps.googleapis.com/maps/api/geocode/json?latlng=' + lat + ',' + long + '&key=AIzaSyDbMfrJkOsAaEwi7fHIYoq8vTRhdvpDE3A';

    axios(moreUrl)
        .then(function (response) {
            addr = response.data.results[0].formatted_address.replaceAll(", ", ",").replaceAll(" ", "+");

            let coords = lat + "," + long;

            let newURL = "https://www.google.com/maps/embed/v1/streetview" +
                "?key=AIzaSyDbMfrJkOsAaEwi7fHIYoq8vTRhdvpDE3A" +
                "&location=" + coords +
                "&heading=210" +
                "&pitch=10" +
                "&fov=90";

            let placeURL = "https://www.google.com/maps/embed/v1/place" +
                "?key=AIzaSyDbMfrJkOsAaEwi7fHIYoq8vTRhdvpDE3A" +
                "&q=" + addr +
                "&center=" + coords
            "&zoom=16";

            let myScript = document.createElement("iframe");
            myScript.setAttribute("src", newURL);
            myScript.setAttribute("width", "100%");
            myScript.setAttribute("height", "500");
            myScript.setAttribute("frameborder", "0");
            myScript.setAttribute("allowfullscreen", "");
            myScript.setAttribute("loading", "lazy");
            myScript.setAttribute("referrerpolicy", "no-referrer-when-downgrade");
            document.getElementById("StreetView").appendChild(myScript);

            let placeView = document.createElement("iframe");
            placeView.setAttribute("src", placeURL);
            placeView.setAttribute("width", "100%");
            placeView.setAttribute("height", "700");
            placeView.setAttribute("frameborder", "0");
            placeView.setAttribute("allowfullscreen", "");
            placeView.setAttribute("loading", "lazy");
            placeView.setAttribute("referrerpolicy", "no-referrer-when-downgrade");
            document.getElementById("placeView").appendChild(placeView);
        })
})