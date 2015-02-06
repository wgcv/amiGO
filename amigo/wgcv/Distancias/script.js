 var latitud=-2.1709979, longitud=-79.92235920000002;
      var rendererOptions = {
  draggable: true
};
var directionsDisplay = new google.maps.DirectionsRenderer(rendererOptions);
var directionsService = new google.maps.DirectionsService();
var map;
var origen = new google.maps.LatLng(latitud, longitud);
var destino = new google.maps.LatLng(-2.1814114, -79.90597660000003);
var guayaquil = new google.maps.LatLng(-2.1709979, -79.92235920000002);

function initialize() {

  var mapOptions = {
    zoom: 7,
    center: guayaquil,
    disableDefaultUI: true,
    zoomControl: true,
    mapTypeControl: true,
    mapTypeId: google.maps.MapTypeId.ROADMAP
  };
  map = new google.maps.Map(document.getElementById('map-canvas'), mapOptions);
  directionsDisplay.setMap(map);


  google.maps.event.addListener(directionsDisplay, 'directions_changed', function() {
    computeTotalDistance(directionsDisplay.getDirections());
  });

  calcRoute();
}

function calcRoute() {
  var request = {
    origin: origen,
    destination: destino,
   // waypoints:[{location: 'Bourke, NSW'}, {location: 'Broken Hill, NSW'}],
    travelMode: google.maps.TravelMode.DRIVING
  };
  directionsService.route(request, function(response, status) {
    if (status == google.maps.DirectionsStatus.OK) {
      directionsDisplay.setDirections(response);
    }
  });
}

function computeTotalDistance(result) {
  var total = 0;
  var myroute = result.routes[0];
  for (var i = 0; i < myroute.legs.length; i++) {
    total += myroute.legs[i].distance.value;
  }
  total = total / 1000.0;
  document.getElementById('total').innerHTML = total + ' km';
}
//geolocaliza
if (navigator.geolocation)
{

 
function geolocalizar() {
  navigator.geolocation.getCurrentPosition(mostrarLoc,mostrarError);   
   
}
 
function mostrarError(error){                
  alert("Error en la geolocation");
}
  function mostrarLoc(geo){                   
  latitud=geo.coords.latitude;
  longitud=geo.coords.longitude;
  origen = new google.maps.LatLng(latitud, longitud);
calcRoute();
  }

}
else
{
  alert("No soporta geolocation");
} 

google.maps.event.addDomListener(window, 'load', initialize);
window.onload =geolocalizar;  