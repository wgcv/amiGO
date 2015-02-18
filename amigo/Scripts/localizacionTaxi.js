var latitud, longitud;
function redireccionar() {
    alert("hola");
    window.location.href  = "/taxista/?latitud="+latitud+"&longitud="+longitud;


  
}

if (navigator.geolocation) {


    function geolocalizar() {
        navigator.geolocation.getCurrentPosition(mostrarLoc, mostrarError);

    }

    function mostrarError(error) {
        alert("Error en la geolocation");
    }
    function mostrarLoc(geo) {
        latitud = geo.coords.latitude;
        longitud = geo.coords.longitude;

        setTimeout(redireccionar, 1000);
    }
    
}
else {
    alert("No soporta geolocation");
}

window.onload = geolocalizar;  
