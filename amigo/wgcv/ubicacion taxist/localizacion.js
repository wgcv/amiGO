

var map;
var markers=[];

var taxi =  new google.maps.LatLng(-2.581654, -79.94597660000003);
function initialize() {
$.getJSON('../../consultataxi.aspx?id=30381938-62b8-4e56-92ad-cf1bac906134', function(contenidoDelArchivo){
    console.log(contenidoDelArchivo.latitud);
    console.log(contenidoDelArchivo.longitud);
    taxi =  new google.maps.LatLng(contenidoDelArchivo.latitud, contenidoDelArchivo.longitud);
    var mapOptions = {
        zoom: 15,
        center: taxi,
        disableDefaultUI: true,
        zoomControl: true,
        mapTypeControl: true,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
       map = new google.maps.Map(document.getElementById('map-canvas'), mapOptions);
    });
    
 
ubicacion();
        


   
}
function ubicacion(){
$.getJSON('ubicacion.json', function(contenidoDelArchivo){
    console.log(contenidoDelArchivo.latitud);
    console.log(contenidoDelArchivo.longitud);
    taxi =  new google.maps.LatLng(contenidoDelArchivo.latitud, contenidoDelArchivo.longitud);
clearMarkers();

  markers.push(new google.maps.Marker({
    position: taxi,
    map: map,
    animation: google.maps.Animation.DROP
  }));

});
}
function clearMarkers() {
  for (var i = 0; i < markers.length; i++) {
    markers[i].setMap(null);
  }
  markers = [];
}

google.maps.event.addDomListener(window, 'load', initialize);
function actualizar() {
    ubicacion();
    setTimeout(actualizar, 3000); //multiplicas la cantidad de segundos por mil
}
