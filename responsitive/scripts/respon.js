
var mostrado
function reponsitive(){
mostrado = false;

$("#ocultarMenu").click(function(){
$("#menu").hide();
$("nav").show();
});
$("#mostrarMenu").click(function(){
if(mostrado==false){
$("#menu").show();
mostrado=true;
}else
{
$("#menu").hide();
mostrado=false;

}
});
}
